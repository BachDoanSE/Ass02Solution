using BusinessObject;
using System.Data;
using Microsoft.Extensions.Configuration;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberRepository mem = new MemberRepository();
            var DefaultSettings = Program.Configuration.GetSection("DefaultAccounts").Get<DefaultAccount>();
            string AdminEmail = DefaultSettings.Email;
            string AdminPassword = DefaultSettings.Password;
            var member = mem.Login(txtEmail.Text, txtPassword.Text);

            if (txtEmail.Text == AdminEmail && txtPassword.Text == AdminPassword) 
            {
                this.Hide();
                var formManagement = new frmMain();
                formManagement.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password. Please do it again");
                txtPassword.Clear();
            }
        }
    }
}
