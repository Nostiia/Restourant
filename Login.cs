namespace Restourant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Fill all rows!");
            }
            else
            {
                if (UnameTb.Text == "Admin" && PasswordTb.Text == "Admin")
                {
                    Billing Obj = new Billing();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You put wrong credentials:(");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
