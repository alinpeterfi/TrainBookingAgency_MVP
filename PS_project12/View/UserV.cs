using PS_project12.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_project12.View
{
    public partial class UserV : Form, IUser
    {
        public UserV()
        {
            InitializeComponent();
        }

        //normal user view events handling
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserPr utP = new UserPr(this);
            utP.ViewTrainsListByStation();
        }

        private void btnListTrains_Click(object sender, EventArgs e)
        {
            UserPr utP = new UserPr(this);
            utP.ViewTrainsList();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            UserPr utP = new UserPr(this);
            utP.Authentication();
        }


        public string getOrigin()
        {
            return this.cmbOrigin.Text;
        }
        public string getDestination()
        {
            return this.cmbDestination.Text;
        }

        public string getAuthentication()
        {
            return this.btnAuthentication.Text;
        }

        public void updateTrainsList(List<DataGridViewRow> rows)
        {
            this.dgvUser.Rows.Clear();
            foreach (DataGridViewRow row in rows)
            {
                this.dgvUser.Rows.Add(row);
            }
        }

        public void updateView()
        {
            this.Hide(); 
        }


        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            UserPr utP = new UserPr(this);
            utP.ViewTrainByNumber();
        }

        public string getTrainNo()
        {
            return this.txtTrainNo.Text;
        }

        public void setTrainNo(string train)
        {
            this.txtTrainNo.Text = train;
        }
    }
}
