namespace WinFormsApp
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            BtnOK.Click += new EventHandler(BtuEixt_Click);
            this.ResizeBegin += (sender, e) => this.Opacity = .5;
            this.FormClosed += (sender, e) => Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtuEixt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Welcome_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
