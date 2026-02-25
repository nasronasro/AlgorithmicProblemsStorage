using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UIGlobalUse
{
    public class StyledListView : ListView
    {
        private readonly Color _headerBg = Color.FromArgb(52, 73, 94);
        private readonly Color _headerFg = Color.White;

        private readonly Color _rowBg = Color.FromArgb(245, 247, 250);
        private readonly Color _rowFg = Color.FromArgb(44, 62, 80);

        private readonly Color _selBg = Color.FromArgb(52, 152, 219);
        private readonly Color _selFg = Color.White;

        // Set this to the "Link" column index (e.g. 4)
        [DefaultValue(-1)]
        public int LinkColumnIndex { get; set; } = -1;

        private int _hotItemIndex = -1;
        private int _hotSubItemIndex = -1;

        public StyledListView()
        {
            View = View.Details;
            FullRowSelect = true;
            BorderStyle = BorderStyle.None;
            HideSelection = false;

            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            BackColor = _rowBg;
            ForeColor = _rowFg;

            OwnerDraw = true;
            DoubleBuffered = true;

            // Hyperlink behavior
            MouseMove += (_, e) => UpdateHotLink(e.Location);
            MouseLeave += (_, __) => ClearHot();
            MouseUp += (_, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    OpenLinkAt(e.Location);
            };

            // Double click / Enter opens the currently hovered link (if any)
            ItemActivate += (_, __) => OpenHotLink();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            OwnerDraw = true;
            DoubleBuffered = true;
        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            using var bg = new SolidBrush(_headerBg);
            e.Graphics.FillRectangle(bg, e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                e.Header.Text,
                Font,
                e.Bounds,
                _headerFg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            // In Details view, DrawItem is responsible for the FIRST column (label).
            if (View != View.Details)
            {
                e.DrawDefault = true;
                return;
            }

            bool selected = e.Item.Selected;

            var labelBounds = e.Item.GetBounds(ItemBoundsPortion.Label);
            using (var bg = new SolidBrush(selected ? _selBg : _rowBg))
                e.Graphics.FillRectangle(bg, labelBounds);

            TextRenderer.DrawText(
                e.Graphics,
                e.Item.Text,
                Font,
                Rectangle.Inflate(labelBounds, -6, 0),
                selected ? _selFg : _rowFg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            if (View != View.Details)
            {
                e.DrawDefault = true;
                return;
            }

            // Column 0 already drawn in OnDrawItem
            if (e.ColumnIndex == 0)
                return;

            bool selected = e.Item.Selected;

            using var bg = new SolidBrush(selected ? _selBg : _rowBg);
            e.Graphics.FillRectangle(bg, e.Bounds);

            bool isLinkCol = (e.ColumnIndex == LinkColumnIndex) && IsValidUrl(e.SubItem.Text);
            bool isHot = (e.Item.Index == _hotItemIndex && e.ColumnIndex == _hotSubItemIndex);

            if (isLinkCol)
            {
                using var linkFont = new Font(Font, FontStyle.Underline);

                // use selection color when selected, otherwise blue
                var linkColor = selected ? _selFg : Color.RoyalBlue;

                // optional: make it slightly more “hovered”
                if (isHot && !selected)
                    linkColor = Color.Blue;

                TextRenderer.DrawText(
                    e.Graphics,
                    e.SubItem.Text,
                    linkFont,
                    Rectangle.Inflate(e.Bounds, -6, 0),
                    linkColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                return;
            }

            TextRenderer.DrawText(
                e.Graphics,
                e.SubItem.Text,
                Font,
                Rectangle.Inflate(e.Bounds, -6, 0),
                selected ? _selFg : _rowFg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        private void UpdateHotLink(Point location)
        {
            if (LinkColumnIndex < 0)
            {
                Cursor = Cursors.Default;
                return;
            }

            var hit = HitTest(location);
            if (hit.Item == null || hit.SubItem == null)
            {
                ClearHot();
                return;
            }

            int itemIndex = hit.Item.Index;
            int subIndex = hit.Item.SubItems.IndexOf(hit.SubItem);

            bool isLinkCell = subIndex == LinkColumnIndex && IsValidUrl(hit.SubItem.Text);

            Cursor = isLinkCell ? Cursors.Hand : Cursors.Default;

            if (isLinkCell)
                SetHot(itemIndex, subIndex);
            else
                ClearHot();
        }

        private void SetHot(int itemIndex, int subItemIndex)
        {
            if (_hotItemIndex == itemIndex && _hotSubItemIndex == subItemIndex)
                return;

            _hotItemIndex = itemIndex;
            _hotSubItemIndex = subItemIndex;
            Invalidate();
        }

        private void ClearHot()
        {
            if (_hotItemIndex == -1 && _hotSubItemIndex == -1)
                return;

            _hotItemIndex = -1;
            _hotSubItemIndex = -1;
            Cursor = Cursors.Default;
            Invalidate();
        }

        private void OpenLinkAt(Point location)
        {
            if (LinkColumnIndex < 0) return;

            var hit = HitTest(location);
            if (hit.Item == null || hit.SubItem == null) return;

            int subIndex = hit.Item.SubItems.IndexOf(hit.SubItem);
            if (subIndex != LinkColumnIndex) return;

            OpenUrl(hit.SubItem.Text);
        }

        private void OpenHotLink()
        {
            if (LinkColumnIndex < 0) return;
            if (_hotItemIndex < 0 || _hotSubItemIndex != LinkColumnIndex) return;

            var item = Items[_hotItemIndex];
            if (item.SubItems.Count <= LinkColumnIndex) return;

            OpenUrl(item.SubItems[LinkColumnIndex].Text);
        }

        private static bool IsValidUrl(string text)
            => Uri.TryCreate(text, UriKind.Absolute, out var uri)
               && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);

        private static void OpenUrl(string url)
        {
            if (!IsValidUrl(url)) return;

            Process.Start(new ProcessStartInfo(url)
            {
                UseShellExecute = true
            });
        }
    }
}