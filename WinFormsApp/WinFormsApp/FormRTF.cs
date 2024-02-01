using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormRTF : Form
    {
        public FormRTF()
        {
            InitializeComponent();
        }



        private void FormRTF_Load(object sender, EventArgs e)
        {
            btnExit.Click += (sender, e) => this.Close();
            DiaOpen.Filter = "Rich Text Files | *.rtf |Text Files |*.txt";
            DiaSave.Filter = "Rich Text Files | *.rtf |Text Files |*.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (DiaOpen.ShowDialog() == DialogResult.OK)
            {
                switch (DiaOpen.FilterIndex)
                {
                    case 1:
                        txtInput.LoadFile(DiaOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        txtInput.LoadFile(DiaOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            if (DiaSave.ShowDialog() == DialogResult.OK)
                txtInput.SaveFile(DiaSave.FileName, (RichTextBoxStreamType)(DiaOpen.FilterIndex - 1));

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
                DiaFont.Font = txtInput.SelectionFont;
            if (DiaFont.ShowDialog() == DialogResult.OK)
                txtInput.SelectionFont = DiaFont.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
                DiaFont.Color = txtInput.SelectionColor;
            if (DiaColor.ShowDialog() == DialogResult.OK)
                txtInput.SelectionColor = DiaColor.Color;
        }

        DiaCustom DiaCustom = new DiaCustom();
        private void BtnMyDialog_Click(object sender, EventArgs e)
        {
            DiaCustom.CutText = "Write Here...";
            if (DiaCustom.ShowDialog() == DialogResult.OK)
                txtInput.AppendText(DiaCustom.CutText);
        }
    }
}
