
using System.Collections.Generic;
using System.Windows.Forms;

namespace PS_project12.View
{
    public interface IUser
    {
        public string getOrigin();

        public string getDestination();
        public string getAuthentication();

        public string getTrainNo();

        public void setTrainNo(string train);

        public void updateTrainsList(List<DataGridViewRow> rows);

        public void updateView();
    }
}
