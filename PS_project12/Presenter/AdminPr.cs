using PS_project12.Model;
using PS_project12.Model.Persistent;
using PS_project12.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PS_project12.Presenter
{
    public class AdminPr
    {
        private IAdmin admV;
        private UserP utP;

        public AdminPr(IAdmin admV)
        {
            this.admV = admV;
            this.utP = new UserP();
        }
        //function to add user
        public void AddUser()
        {
            bool isCorrect = true;
            int selectedRole = this.admV.getRole();
            if (selectedRole < 0)
            {
                isCorrect = false;
                MessageBox.Show("No role selected!");
            }
            else
            {
                string role = "EMPLOYEE";
                if (selectedRole == 1)
                    role = "ADMIN";
                string username = this.admV.getUsername();
                if (this.utP.SearchUser(username) != null)
                {
                    MessageBox.Show("Account name already exists!");
                    isCorrect = false;
                }
                else
                {
                    string password = this.admV.getPassword();
                    if (isCorrect)
                    {
                        User ut = new User(username, password, role);
                        bool succes = this.utP.AddUser(ut);
                        if (!succes)
                            MessageBox.Show("User Add Error!");
                        else
                            this.ViewList();
                    }
                }
            }
        }

        //function to delete user
        public void DeleteUser()
        {
            string selectedUser = this.admV.getSelectedUsername();
            if (selectedUser == null)
                MessageBox.Show("No user selected!");
            else
            {
                bool succes = this.utP.DeleteUser(selectedUser);
                if (!succes)
                    MessageBox.Show("User not Deleted!");
                else
                    this.ViewList();
            }
        }

        //function to update user
        public void UpdateUser()
        {
            string selectedUser = this.admV.getSelectedUsername();
            if (selectedUser == null)
                MessageBox.Show("No user selected!");
            else
            {
                bool isCorrect = true;
                int selectedRole = this.admV.getRole();
                if (selectedRole < 0)
                {
                    isCorrect = false;
                    MessageBox.Show("No role selected!");
                }
                else
                {
                    string role = "EMPLOYEE";
                    if (selectedRole == 1)
                        role = "ADMIN";

                        string password = this.admV.getPassword();

                        if (isCorrect)
                        {
                        string user = this.admV.getUsername();
                        User ut;
                            if(user != selectedUser)
                        {
                             ut = new User(user, password, role);
                        }
                        else
                        {
                            ut = new User(selectedUser, password, role);
                        }
                         
                            bool succes = this.utP.UpdateUser(selectedUser, ut);
                            if (!succes)
                                MessageBox.Show("User Update Error!");
                            else
                                this.ViewList();
                        
                    }
                }
            }
        }

        //function to view users
        public void ViewList()
        {
            List<User> list = this.utP.ListUser();

            if (list != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (User ut in list)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getUserName() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getPassword() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getRole() });
                    randuri.Add(rand);
                }
                this.admV.updateUserList(randuri);
            }
            else
                MessageBox.Show("List is empty!");
        }
    }
}
