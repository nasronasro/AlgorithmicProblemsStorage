namespace AlgorithmicProblemsStorage.Presentation.Controls
{
    partial class AlgorithmAddControl
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
            txtTags = new TextBox();
            label1 = new Label();
            txtCode = new CsharpEditor();
            label3 = new Label();
            lblTitle = new Label();
            txtLink = new TextBox();
            txtTitle = new TextBox();
            cbDifficulty = new ComboBox();
            cbPlatform = new ComboBox();
            label2 = new Label();
            lblPlatform = new Label();
            lblCode = new Label();
            btnConfirm = new UIGlobalUse.PrimaryButton();
            btnCancel = new UIGlobalUse.DangerButton();
            SuspendLayout();
            // 
            // txtTags
            // 
            txtTags.Location = new Point(831, 25);
            txtTags.Multiline = true;
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(116, 69);
            txtTags.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(784, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 35;
            label1.Text = "Tags:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(22, 108);
            txtCode.MinimumSize = new Size(200, 120);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(935, 379);
            txtCode.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 66);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 33;
            label3.Text = "Link:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(55, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 20);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Algorithm Title:";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(173, 63);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(311, 27);
            txtLink.TabIndex = 31;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(173, 25);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(311, 27);
            txtTitle.TabIndex = 30;
            // 
            // cbDifficulty
            // 
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Location = new Point(582, 66);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(186, 28);
            cbDifficulty.TabIndex = 29;
            // 
            // cbPlatform
            // 
            cbPlatform.FormattingEnabled = true;
            cbPlatform.Location = new Point(582, 24);
            cbPlatform.Name = "cbPlatform";
            cbPlatform.Size = new Size(186, 28);
            cbPlatform.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 69);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 27;
            label2.Text = "Difficulty:";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(510, 27);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(69, 20);
            lblPlatform.TabIndex = 26;
            lblPlatform.Text = "Platform:";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(22, 85);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(47, 20);
            lblCode.TabIndex = 25;
            lblCode.Text = "Code:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(52, 152, 219);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(634, 493);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(157, 53);
            btnConfirm.TabIndex = 24;
            btnConfirm.Text = "Add";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(800, 493);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 53);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AlgorithmAddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTags);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(txtLink);
            Controls.Add(txtTitle);
            Controls.Add(cbDifficulty);
            Controls.Add(cbPlatform);
            Controls.Add(label2);
            Controls.Add(lblPlatform);
            Controls.Add(lblCode);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Name = "AlgorithmAddControl";
            Size = new Size(988, 566);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTags;
        private Label label1;
        private CsharpEditor txtCode;
        private Label label3;
        private Label lblTitle;
        private TextBox txtLink;
        private TextBox txtTitle;
        private ComboBox cbDifficulty;
        private ComboBox cbPlatform;
        private Label label2;
        private Label lblPlatform;
        private Label lblCode;
        private UIGlobalUse.PrimaryButton btnConfirm;
        private UIGlobalUse.DangerButton btnCancel;
    }
}
