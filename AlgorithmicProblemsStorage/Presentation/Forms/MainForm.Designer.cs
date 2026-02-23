namespace AlgorithmicProblemsStorage
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddAlgo = new UIGlobalUse.PrimaryButton();
            SuspendLayout();
            // 
            // btnAddAlgo
            // 
            btnAddAlgo.BackColor = Color.FromArgb(52, 152, 219);
            btnAddAlgo.FlatAppearance.BorderSize = 0;
            btnAddAlgo.FlatStyle = FlatStyle.Flat;
            btnAddAlgo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAlgo.ForeColor = Color.White;
            btnAddAlgo.Location = new Point(269, 161);
            btnAddAlgo.Name = "btnAddAlgo";
            btnAddAlgo.Size = new Size(153, 48);
            btnAddAlgo.TabIndex = 0;
            btnAddAlgo.Text = "Add Algorithm";
            btnAddAlgo.UseVisualStyleBackColor = false;
            btnAddAlgo.Click += btnAddAlgo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 415);
            Controls.Add(btnAddAlgo);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private UIGlobalUse.PrimaryButton btnAddAlgo;
    }
}
