namespace BanNuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin123" && txtPassword.Text == "123456")
            {
                Bangdieukhien bdk = new Bangdieukhien("Admin");
                bdk.Show();
                this.Hide();
            }
            else if(txtUsername.Text =="staff123" && txtPassword.Text == "123456")
            {
                Bangdieukhien bdk = new Bangdieukhien("Staff");
                bdk.Show();
                this.Hide();
            }
        }

        private void btnGuest_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bangdieukhien ds = new Bangdieukhien("Guest");
            ds.Show();
            this.Hide();
        }
    }
}
