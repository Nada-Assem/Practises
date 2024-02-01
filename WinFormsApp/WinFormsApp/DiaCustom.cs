using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class DiaCustom : Form
    {
        public DiaCustom()
        {
            InitializeComponent();

        }

        public string CutText
        {
            get => this.txtBox.Text;
            set => this.txtBox.Text = value;
        }
    }
}
