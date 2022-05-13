using PS_project12.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PS_project12.View
{
    public partial class EmployeeV : UserV, IEmployee
    {
        private EmployeePr empPr;

        public EmployeeV()
        {
            InitializeComponent();
            this.btnAuthentication.Text = "LOGOUT";
            this.empPr = new EmployeePr(this);
        }

        //employee view events handling
        public int getSelectedTrain()
        {

            if (this.dgvUser.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvUser.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvUser.Rows[selectedrowindex];
                return Convert.ToInt32(selectedRow.Cells["TicketId"].Value);
            }
            else
                return -1;
        }
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if (this.empPr.AddTicket())
            {
                if (!cmbOrigin.Items.Contains(this.getOriginEmp())) //daca locatia nu exista deja in combobox
                this.cmbOrigin.Items.Add(this.getOriginEmp());
                if (!cmbDestination.Items.Contains(this.getDestinationEmp()))
                    this.cmbDestination.Items.Add(this.getDestinationEmp());
            }
        }

        public string getTrainEmp()
        {
            return this.txtTrainE.Text;
        }

        public string getOriginEmp()
        {
            return this.txtOriginE.Text;
        }

        public string getDestinationEmp()
        {
            return this.txtDestinationE.Text;
        }

        public string getDurationEmp()
        {
            return this.txtDurationE.Text;
        }

        public string getSeatsEmp()
        {
            return this.txtSeatsE.Text;
        }

        public string getPriceEmp()
        {
            return this.txtPriceE.Text;
        }

        public string getIdEmp()
        {
            return this.txtIdE.Text;
        }

        public void updateTicketList(List<DataGridViewRow> list)
        {
            this.dgvUser.Rows.Clear();
            foreach (DataGridViewRow row in list)
                this.dgvUser.Rows.Add(row);
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            this.empPr.DeleteTicket();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (this.empPr.UpdateTicket())
            {
                if (!cmbOrigin.Items.Contains(this.getOriginEmp())) //daca locatia nu exista deja in combobox
                    this.cmbOrigin.Items.Add(this.getOriginEmp());
                if (!cmbDestination.Items.Contains(this.getDestinationEmp()))
                    this.cmbDestination.Items.Add(this.getDestinationEmp());
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            this.empPr.SellTicketAction(0);
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.empPr.SellTicketAction(30);
        }
    }
}
