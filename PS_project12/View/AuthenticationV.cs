using System;
using System.Windows.Forms;
using PS_project12.Presenter;


namespace PS_project12.View
{
    public partial class AuthenticationV : Form, IAuthentication
    {
        public AuthenticationV()
        {
            InitializeComponent();
        }

        //authentication view events handling
        public string getPassword()
        {
            return this.txtPassword.Text;
        }

        public string getUsername()
        {
            return this.txtUsername.Text; 
        }

        public void setPassword(string password)
        {
            this.txtPassword.Text = password;
        }

        public void setUsername(string user)
        {
            this.txtUsername.Text = user;
        }

        public void updateView()
        {
            this.Hide();
        }

  

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            AuthenticationPr aPr = new AuthenticationPr(this);
            aPr.Login();
        }
    }
}
