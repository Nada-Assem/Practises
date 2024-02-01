namespace WinFormsApp
{
    partial class Welcome
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
            BtnOK = new Button();
            BtuEixt = new Button();
            SuspendLayout();
            // 
            // BtnOK
            // 
            BtnOK.BackColor = SystemColors.ControlDark;
            BtnOK.Location = new Point(612, 400);
            BtnOK.Margin = new Padding(4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(129, 36);
            BtnOK.TabIndex = 0;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = false;
            // 
            // BtuEixt
            // 
            BtuEixt.AutoSize = true;
            BtuEixt.BackColor = SystemColors.ActiveBorder;
            BtuEixt.Location = new Point(75, 400);
            BtuEixt.Margin = new Padding(4);
            BtuEixt.Name = "BtuEixt";
            BtuEixt.Size = new Size(129, 36);
            BtuEixt.TabIndex = 1;
            BtuEixt.Text = "Exit";
            BtuEixt.UseVisualStyleBackColor = false;
            BtuEixt.Click += BtuEixt_Click;
            // 
            // Welcome
            // 
            AcceptButton = BtnOK;
            AccessibleName = "Welcome";
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._1199748;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = BtuEixt;
            ClientSize = new Size(830, 453);
            Controls.Add(BtuEixt);
            Controls.Add(BtnOK);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Form1_Load;
            ResizeEnd += Welcome_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOK;
        private Button BtuEixt;
    }
}
