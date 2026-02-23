namespace AlgorithmicProblemsStorage.Presentation.Forms.AlgorithmForms
{
    partial class AddAlgorithmForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new UIGlobalUse.DangerButton();
            btnConfirm = new UIGlobalUse.PrimaryButton();
            lblCode = new Label();
            lblPlatform = new Label();
            label2 = new Label();
            cbPlatform = new ComboBox();
            cbDifficulty = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblTitle = new Label();
            label3 = new Label();
            csharpEditor1 = new AlgorithmicProblemsStorage.Presentation.Controls.CsharpEditor();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(790, 480);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 53);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(52, 152, 219);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(624, 480);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(157, 53);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Add";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(12, 72);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(47, 20);
            lblCode.TabIndex = 11;
            lblCode.Text = "Code:";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(686, 12);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(69, 20);
            lblPlatform.TabIndex = 12;
            lblPlatform.Text = "Platform:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 54);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 13;
            label2.Text = "Difficulty:";
            // 
            // cbPlatform
            // 
            cbPlatform.FormattingEnabled = true;
            cbPlatform.Location = new Point(761, 12);
            cbPlatform.Name = "cbPlatform";
            cbPlatform.Size = new Size(186, 28);
            cbPlatform.TabIndex = 14;
            // 
            // cbDifficulty
            // 
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Location = new Point(761, 51);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(186, 28);
            cbDifficulty.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 27);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 27);
            textBox2.TabIndex = 17;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 20);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Algorithm Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 52);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 19;
            label3.Text = "Link:";
            // 
            // csharpEditor1
            // 
            csharpEditor1.Location = new Point(12, 95);
            csharpEditor1.MinimumSize = new Size(200, 120);
            csharpEditor1.Name = "csharpEditor1";
            csharpEditor1.Size = new Size(935, 379);
            csharpEditor1.TabIndex = 20;
            // 
            // AddAlgorithmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 545);
            Controls.Add(csharpEditor1);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cbDifficulty);
            Controls.Add(cbPlatform);
            Controls.Add(label2);
            Controls.Add(lblPlatform);
            Controls.Add(lblCode);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Name = "AddAlgorithmForm";
            Text = "AddAlgorithmForm";
            Load += AddAlgorithmForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UIGlobalUse.DangerButton btnCancel;
        private UIGlobalUse.PrimaryButton btnConfirm;
        private Label lblCode;
        private Label lblPlatform;
        private Label label2;
        private ComboBox cbPlatform;
        private ComboBox cbDifficulty;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblTitle;
        private Label label3;
        private Controls.CsharpEditor csharpEditor1;
    }
}