using PS_project12.View;
using PS_project12.Model.Persistent;
using PS_project12.Model;
using System.Windows.Forms;

namespace PS_project12.Presenter
{
    public class AuthenticationPr
    {
        private IAuthentication authentication;
        private UserP uP;

        public AuthenticationPr(IAuthentication authenticationV)
        {
            this.authentication = authenticationV;
            this.uP = new UserP();
        }

        //atuthentication function
        public void Login()
        {
            string user = this.authentication.getUsername();
            string password = this.authentication.getPassword();
            User ut = this.uP.SearchUser(user, password);

            if (ut == null)
            {
                MessageBox.Show("Wrong credentials!");
                this.authentication.setUsername("");
                this.authentication.setPassword("");
            }
            else
            {
                this.authentication.updateView();
                string rol = ut.getRole();
               if (rol.ToUpper() == "ADMIN")
                {
                    AdminV adV = new AdminV();
                    adV.Show();

                } 
                else
                {
                    EmployeeV empV = new EmployeeV();
                    empV.Show();
                }
            }
        }
    }
}
