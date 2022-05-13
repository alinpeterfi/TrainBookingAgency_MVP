using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PS_project12.Model;
using PS_project12.Model.Persistent;
using PS_project12.View;


namespace PS_project12.Presenter
{
    public class UserPr
    {
        private IUser userView;
        private TicketP tP;

        public UserPr(IUser uV)
        {
            this.userView = uV;
            this.tP = new TicketP();
        }


        public void Authentication()
        {
            if(this.userView.getAuthentication().ToString() == "AUTHENTICATION")
            {
                AuthenticationV aV = new AuthenticationV();
                aV.Show();
                this.userView.updateView();
            }
            else
            {
                this.userView.updateView();
                UserV utV = new UserV();
                utV.Show();
            }
        }

        //no login user
        //function used for viewing trains
        public void ViewTrainsList()
        {
            List<Ticket> list = new List<Ticket>();
    
                list = this.tP.TicketList();
            if (list != null)
            {
                List<DataGridViewRow> row = new List<DataGridViewRow>();
                foreach (Ticket t in list)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getTrainNo().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getOriginStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDestinationStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDuration().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getSeats().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getPrice().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getId().ToString() });
                    row.Add(rand);
                }
                this.userView.updateTrainsList(row);
            }
            else
                MessageBox.Show("The list is empty!");
        }
        //view filter functions
        //view trains on 2 conditions
        public void ViewTrainsListByStation()
        {
            List<Ticket> list = new List<Ticket>();
            string origin = this.userView.getOrigin();
            string destination = this.userView.getDestination();

            list = this.tP.FilterTicketsByLocation(origin, destination);
            if (list != null)
            {
                List<DataGridViewRow> row = new List<DataGridViewRow>();
                foreach (Ticket t in list)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getTrainNo().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getOriginStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDestinationStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDuration().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getSeats().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getPrice().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getId().ToString() });
                    row.Add(rand);
                }
                this.userView.updateTrainsList(row);
            }
            else
                MessageBox.Show("Error listing the trains by stations!");
        }

        //view trains on 1 condition
        public void ViewTrainByNumber()
        {
            List<Ticket> list = new List<Ticket>();
            string s = this.userView.getTrainNo();
            bool isTrain = string.IsNullOrEmpty(s);
            int trainNo = 0;
            int n;
            bool isNumeric = int.TryParse(s, out n);
            if (!isTrain && isNumeric)
            {
               trainNo = Convert.ToInt32(s);
            }

            
            list = this.tP.FilterTicketsByTrain(trainNo);
            if (list != null)
            {
                List<DataGridViewRow> row = new List<DataGridViewRow>();
                foreach (Ticket t in list)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getTrainNo().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getOriginStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDestinationStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getDuration().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getSeats().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getPrice().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = t.getId().ToString() });
                    row.Add(rand);
                }
                this.userView.updateTrainsList(row);
            }
            else
            {
                this.userView.setTrainNo("");
                MessageBox.Show("The train does not exist!");
            }
        }
    }//UserPr
}
