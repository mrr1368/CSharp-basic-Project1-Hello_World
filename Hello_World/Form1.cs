namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();

            if (!string.IsNullOrEmpty(fullName))
            {
                lblMesssage.Text = "سلام " + fullName + " خوش آمدی";
                lblMesssage.ForeColor = Color.Purple;
            }
            else
            {
                MessageBox.Show("لطفا نام خود را وارد کنید");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.Close();   
            }   
        }
    }
}
