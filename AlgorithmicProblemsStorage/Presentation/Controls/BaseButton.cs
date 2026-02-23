using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGlobalUse
{
    public abstract class BaseButton : Button
    {
        protected BaseButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Height = 38;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
        }

        protected void ConfigureColors(Color normal, Color hover, Color pressed)
        {
            BackColor = normal;
            ForeColor = Color.White;

            MouseEnter += (_, _) => BackColor = hover;
            MouseLeave += (_, _) => BackColor = normal;
            MouseDown += (_, _) => BackColor = pressed;
            MouseUp += (_, _) => BackColor = hover;
        }
    }
}
