using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_project12.View
{
    public interface IAuthentication
    {
        public string getUsername();
        public string getPassword();

        public void setUsername(string user);

        public void setPassword(string password);

        public void updateView();

    }
}
