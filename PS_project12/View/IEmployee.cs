using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_project12.View
{
    public interface IEmployee
    {
        public string getTrainEmp();
        public string getOriginEmp();
        public string getDestinationEmp();
        public string getDurationEmp();
        public string getSeatsEmp();
        public string getPriceEmp();
        public string getIdEmp();
        public int getSelectedTrain();

        public void updateTicketList(List<DataGridViewRow> list);

    }
}
