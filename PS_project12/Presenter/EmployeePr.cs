using PS_project12.Model;
using PS_project12.Model.Persistent;
using PS_project12.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PS_project12.Presenter
{
    public class EmployeePr
    {
        private IEmployee empV;
        private TicketP ticP;

        public EmployeePr(IEmployee empV)
        {
            this.empV = empV;
            this.ticP = new TicketP();
        }

        //function to view employees
        public void ViewList()
        {
            List<Ticket> list = this.ticP.TicketList();

            if (list != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Ticket ut in list)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getTrainNo() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getOriginStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getDestinationStation() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getDuration() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getSeats() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getPrice() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.getId() });
                    randuri.Add(rand);
                }
                this.empV.updateTicketList(randuri);
            }
            else
                MessageBox.Show("List is empty!");
        }

        //function used for data validation
        public Ticket validation(string trainString, string origin, string destination, string durationString, string seatsString, string priceString, string idString)
        {
            int n, trainNo = 0, duration = 0, seats = 0, id = 0;
            double y, price = 0;
            bool isCorrect = true;
            if (string.IsNullOrEmpty(trainString) || string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(durationString) || string.IsNullOrEmpty(seatsString) || string.IsNullOrEmpty(priceString) || string.IsNullOrEmpty(idString))
            {
                MessageBox.Show("All the fields are required!");
                isCorrect = false;
                return null;
            }
            //verificare numeric
            else
            {
                bool isTrain = int.TryParse(trainString, out n);
                bool isSeats = int.TryParse(seatsString, out n);
                bool isDuration = int.TryParse(durationString, out n);
                bool isPrice = double.TryParse(priceString, out y);
                bool isId = int.TryParse(idString, out n);

                if (isTrain && isSeats && isDuration && isPrice && isId)
                {//conversie in caz de not null null si numeric
                    trainNo = Convert.ToInt32(trainString);
                    duration = Convert.ToInt32(durationString);
                    seats = Convert.ToInt32(seatsString);
                    price = Convert.ToDouble(priceString);
                    id = Convert.ToInt32(idString);
                }
                else
                {
                    isCorrect = false;
                    MessageBox.Show("Fields 'Train No', 'duration','seats', 'price', 'id' must be numbers!");
                    return null;
                }

                if (this.ticP.TicketSearch(id) != null)
                {
                    isCorrect = false;
                    MessageBox.Show("The ticket number already exists!");
                    return null;
                }
                else
                {
                    if (isCorrect)
                    {
                        return new Ticket(trainNo, origin, destination, duration, seats, price, id);
                    }
                }
            }
            return null;
        }

        //function for adding a ticket
            public bool AddTicket()
        {
            string trainString = this.empV.getTrainEmp();
            string origin = this.empV.getOriginEmp();
            string destination = this.empV.getDestinationEmp();
            string durationString = this.empV.getDurationEmp();
            string seatsString = this.empV.getSeatsEmp();
            string priceString = this.empV.getPriceEmp();
            string idString = this.empV.getIdEmp();

            //verificare string null

           Ticket ut = this.validation(trainString, origin, destination, durationString, seatsString, priceString, idString);
            if (ut != null)
            {
                bool succes = this.ticP.AddTicket(ut);
                if (!succes)
                    MessageBox.Show("Ticket Add Error!");
                else
                    this.ViewList();
                MessageBox.Show("Tciket added successfully!");
                return true;
            }
            return false;
        }

        //function for ticket deletion
        public void DeleteTicket()
        {
            int selectedTicket = this.empV.getSelectedTrain();
            if (selectedTicket == -1)
            {
                MessageBox.Show("No ticket selected!");
            }
            else
            {
                bool succes = this.ticP.DeleteTicket(selectedTicket);
                if (!succes)
                {
                    MessageBox.Show("Ticket Delete Error!");
                }
                else
                {
                    this.ViewList();
                    MessageBox.Show("Ticket deleted!");
                }
            }
        }

        //function fot ticket update
        public bool UpdateTicket()
        {
            int SelectedTicket = this.empV.getSelectedTrain();
            if (SelectedTicket == -1)
            {
                MessageBox.Show("No user selected!");
                return false;
            }
            else
            {
                string trainString = this.empV.getTrainEmp();
                string origin = this.empV.getOriginEmp();
                string destination = this.empV.getDestinationEmp();
                string durationString = this.empV.getDurationEmp();
                string seatsString = this.empV.getSeatsEmp();
                string priceString = this.empV.getPriceEmp();
                string idString = this.empV.getIdEmp();
                //validare inputs
                Ticket ut = this.validation(trainString, origin, destination, durationString, seatsString, priceString, idString);
                if (ut != null)
                {
                    bool succes = this.ticP.UpdateTicket(SelectedTicket, ut);
                    if (!succes)
                        MessageBox.Show("Ticket Update Error!");
                    else
                    {
                        this.ViewList();
                        MessageBox.Show("Ticket updated successfully!");
                    }
                    return true;
                }
                return false;
            }
        }

        //function ticket sell
        public void SellTicketAction(int offset)
        {
            int SelectedTicket = this.empV.getSelectedTrain();
            if (SelectedTicket == -1)
            {
                MessageBox.Show("No user selected!");
            }
            else
            {
                Ticket ut = this.ticP.TicketSell(SelectedTicket, offset);//0 deoarece vindem
                if (ut == null)
                {
                    MessageBox.Show("Tickets are sold out!");
                }
                else
                {
                    bool succes = this.ticP.UpdateTicket(SelectedTicket, ut);
                    if (!succes)
                        MessageBox.Show("Ticket Sell Error!");
                    else
                    {
                        this.ViewList();
                        MessageBox.Show("Ticket updated successfully!");
                    }
                }
            }
        }
    }
}

