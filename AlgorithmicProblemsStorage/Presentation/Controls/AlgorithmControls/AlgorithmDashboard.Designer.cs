namespace AlgorithmicProblemsStorage.Presentation.Controls.AlgorithmControls
{
    partial class AlgorithmDashboard
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
            btnAddAlgo = new UIGlobalUse.PrimaryButton();
            BtnDisplay = new UIGlobalUse.PrimaryButton();
            SuspendLayout();
            // 
            // btnAddAlgo
            // 
            btnAddAlgo.BackColor = Color.FromArgb(52, 152, 219);
            btnAddAlgo.FlatAppearance.BorderSize = 0;
            btnAddAlgo.FlatStyle = FlatStyle.Flat;
            btnAddAlgo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAlgo.ForeColor = Color.White;
            btnAddAlgo.Location = new Point(440, 205);
            btnAddAlgo.Name = "btnAddAlgo";
            btnAddAlgo.Size = new Size(153, 48);
            btnAddAlgo.TabIndex = 2;
            btnAddAlgo.Text = "Add Algorithm";
            btnAddAlgo.UseVisualStyleBackColor = false;
            btnAddAlgo.Click += btnAddAlgo_Click;
            // 
            // BtnDisplay
            // 
            BtnDisplay.BackColor = Color.FromArgb(52, 152, 219);
            BtnDisplay.FlatAppearance.BorderSize = 0;
            BtnDisplay.FlatStyle = FlatStyle.Flat;
            BtnDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnDisplay.ForeColor = Color.White;
            BtnDisplay.Location = new Point(430, 259);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(172, 50);
            BtnDisplay.TabIndex = 3;
            BtnDisplay.Text = "Show Algorithmes";
            BtnDisplay.UseVisualStyleBackColor = false;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // AlgorithmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddAlgo);
            Controls.Add(BtnDisplay);
            Name = "AlgorithmDashboard";
            Size = new Size(1000, 500);
            ResumeLayout(false);
        }

        #endregion

        private UIGlobalUse.PrimaryButton btnAddAlgo;
        private UIGlobalUse.PrimaryButton BtnDisplay;
    }
}
