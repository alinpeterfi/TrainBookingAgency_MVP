using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_project12.View
{
    public interface IAdmin
    {
        public string getUsername();
        public string getPassword();
        public int getRole();

        public string getSelectedUsername();

        public void updateUserList(List<DataGridViewRow> list);


    }
}
