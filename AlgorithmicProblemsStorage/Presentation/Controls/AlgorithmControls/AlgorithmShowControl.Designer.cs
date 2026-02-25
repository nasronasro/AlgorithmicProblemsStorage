namespace AlgorithmicProblemsStorage.Presentation.Controls
{
    partial class AlgorithmShowControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstAlgorithms = new UIGlobalUse.StyledListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnReturn = new UIGlobalUse.DangerButton();
            SuspendLayout();
            // 
            // lstAlgorithms
            // 
            lstAlgorithms.BackColor = Color.FromArgb(245, 247, 250);
            lstAlgorithms.BorderStyle = BorderStyle.None;
            lstAlgorithms.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstAlgorithms.Font = new Font("Segoe UI", 10F);
            lstAlgorithms.ForeColor = Color.FromArgb(44, 62, 80);
            lstAlgorithms.FullRowSelect = true;
            lstAlgorithms.Location = new Point(58, 49);
            lstAlgorithms.Name = "lstAlgorithms";
            lstAlgorithms.OwnerDraw = true;
            lstAlgorithms.Size = new Size(877, 389);
            lstAlgorithms.TabIndex = 1;
            lstAlgorithms.UseCompatibleStateImageBehavior = false;
            lstAlgorithms.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Algorithm";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Difficulty";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Platforme";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Link";
            columnHeader5.Width = 230;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(231, 76, 60);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(831, 444);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(157, 53);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // AlgorithmShowControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReturn);
            Controls.Add(lstAlgorithms);
            Name = "AlgorithmShowControl";
            Size = new Size(1000, 500);
            Load += AlgorithmShowControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private UIGlobalUse.StyledListView lstAlgorithms;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private UIGlobalUse.DangerButton btnReturn;
    }
}
