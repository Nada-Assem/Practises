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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnCancel.Click += new EventHandler(Cancel_Click);
            btnLogin.Click += new EventHandler(butLogin_Click);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        Welcome welcome = new Welcome();

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Nada" && (txtPassword.Text == "123"))
            {
                this.Hide();
                welcome.Show();
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want Cancel? " ,
                "Warning" ,
                MessageBoxButtons.YesNo ,
                MessageBoxIcon.Warning ,    
                MessageBoxDefaultButton.Button2) == DialogResult.No) 
                e.Cancel = true;
            
        }
    }
}
