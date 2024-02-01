namespace WinFormsApp
{
    partial class FormRTF
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
            btnOpen = new Button();
            btuSave = new Button();
            btnExit = new Button();
            btnFont = new Button();
            btnColor = new Button();
            BtnMyDialog = new Button();
            txtInput = new RichTextBox();
            DiaOpen = new OpenFileDialog();
            DiaSave = new SaveFileDialog();
            DiaFont = new FontDialog();
            DiaColor = new ColorDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = SystemColors.ActiveCaption;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnOpen.Location = new Point(28, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 40);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btuSave
            // 
            btuSave.Anchor = AnchorStyles.Top;
            btuSave.BackColor = SystemColors.ActiveCaption;
            btuSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btuSave.Location = new Point(349, 12);
            btuSave.Name = "btuSave";
            btuSave.Size = new Size(94, 40);
            btuSave.TabIndex = 1;
            btuSave.Text = "Save";
            btuSave.UseVisualStyleBackColor = false;
            btuSave.Click += btuSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnExit.Location = new Point(672, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFont.BackColor = SystemColors.ActiveCaption;
            btnFont.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnFont.Location = new Point(19, 412);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(103, 36);
            btnFont.TabIndex = 3;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = false;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom;
            btnColor.BackColor = SystemColors.ActiveCaption;
            btnColor.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnColor.Location = new Point(340, 412);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(103, 36);
            btnColor.TabIndex = 4;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // BtnMyDialog
            // 
            BtnMyDialog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnMyDialog.BackColor = SystemColors.ActiveCaption;
            BtnMyDialog.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtnMyDialog.Location = new Point(643, 412);
            BtnMyDialog.Name = "BtnMyDialog";
            BtnMyDialog.Size = new Size(145, 36);
            BtnMyDialog.TabIndex = 5;
            BtnMyDialog.Text = "My Dialog";
            BtnMyDialog.UseVisualStyleBackColor = false;
            BtnMyDialog.Click += BtnMyDialog_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(5, 58);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(785, 348);
            txtInput.TabIndex = 6;
            txtInput.Text = "";
            // 
            // DiaOpen
            // 
            DiaOpen.InitialDirectory = "D:";
            // 
            // FormRTF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 453);
            Controls.Add(txtInput);
            Controls.Add(BtnMyDialog);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Controls.Add(btnExit);
            Controls.Add(btuSave);
            Controls.Add(btnOpen);
            MinimumSize = new Size(500, 500);
            Name = "FormRTF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRTF";
            Load += FormRTF_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btuSave;
        private Button btnExit;
        private Button btnFont;
        private Button btnColor;
        private Button BtnMyDialog;
        private RichTextBox txtInput;
        private OpenFileDialog DiaOpen;
        private SaveFileDialog DiaSave;
        private FontDialog DiaFont;
        private ColorDialog DiaColor;
    }
}