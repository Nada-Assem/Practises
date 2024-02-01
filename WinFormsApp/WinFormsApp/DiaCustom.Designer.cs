namespace WinFormsApp
{
    partial class DiaCustom
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
            btnOK = new Button();
            btnCancel = new Button();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ActiveCaption;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(41, 290);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 44);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(582, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 12);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(706, 270);
            txtBox.TabIndex = 0;
            // 
            // DiaCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 338);
            Controls.Add(txtBox);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiaCustom";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DiaCustom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtBox;
    }
}