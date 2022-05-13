using PS_project12.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PS_project12.View
{
    public partial class AdminV : UserV, IAdmin
    {
        private AdminPr admPr;
        public AdminV()
        {
            InitializeComponent();
            this.btnAuthentication.Text = "LOGOUT";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.admPr = new AdminPr(this);
        }

        //admin view event handling
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.admPr.AddUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.admPr.UpdateUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.admPr.DeleteUser();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            this.admPr.ViewList();
        }

        public string getUsername()
        {
            return this.txtUser.Text;
        }

        public string getPassword()
        {
            return this.txtPassword.Text;
        }

        public int getRole()
        {
            return this.cmbRoleUser.SelectedIndex;
        }

        public void updateUserList(List<DataGridViewRow> list)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow row in list)
                this.dataGridView1.Rows.Add(row);
        }

        public string getSelectedUsername()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return this.dataGridView1.SelectedCells[0].Value.ToString();
            else
                return null;
        }
    }
}
