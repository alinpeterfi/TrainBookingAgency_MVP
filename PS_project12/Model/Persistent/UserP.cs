using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace PS_project12.Model.Persistent
{
    public class UserP
    {
        //XML user adding handling
        public bool AddUser(User ut)
        {
            try
            {
                XElement xElement = XElement.Load(@"users.xml");
                xElement.Add(new XElement("user",
                    new XElement("userName", ut.getUserName()),
                    new XElement("password", ut.getPassword()),
                    new XElement("role", ut.getRole())
                    ));
                xElement.Save(@"users.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Add Error! " + ex.ToString());
                return false;
            }
        }

        //XML user deletion handling
        public bool DeleteUser(string userName)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                xDoc.Root.Elements("user").Where(e => e.Element("userName").Value == userName).Remove();
                xDoc.Save(@"users.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Delete Error! " + ex.ToString());
                return false;
            }
        }

        //XML user update handling
        public bool UpdateUser(string userName, User ut)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                var element = xDoc.Root.Elements("user").Where(e => e.Element("userName").Value == userName).Single();
                element.Element("userName").Value = ut.getUserName();
                element.Element("password").Value = ut.getPassword();
                element.Element("role").Value = ut.getRole();
                xDoc.Save(@"users.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Update Error! " + ex.ToString());
                return false;
            }
        }
        //XML user search handling on 2 conditions
        public User SearchUser(string userName, string password)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                List<XElement> list = xDoc.Root.Elements("user").ToList();
                foreach (XElement xElem in list)
                {
                    string user = xElem.Element("userName").Value;
                    string pass = xElem.Element("password").Value;
                    if (userName.ToUpper() == user.ToUpper() && password == pass)
                    {
                        string role = xElem.Element("role").Value;
                        User ut = new User(userName, password, role);
                        return ut;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Search Error! " + ex.ToString());
                return null;
            }
        }

        //XML user search handling on 1 condition
        public User SearchUser(string userName)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                List<XElement> list = xDoc.Root.Elements("user").ToList();
                foreach (XElement xElem in list)
                {
                    string user = xElem.Element("userName").Value;
                    string password = xElem.Element("password").Value;
                    if (userName.ToUpper() == user.ToUpper())
                    {
                        string role = xElem.Element("role").Value;
                        User ut = new User(userName, password, role);
                        return ut;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Search Error! " + ex.ToString());
                return null;
            }
        }

        //XML user conditioned data fetch handling
        public List<User> ListUser()
        {
            try
            {
                List<User> listUser = new List<User>();
                XDocument xDoc = XDocument.Load(@"users.xml");
                List<XElement> listXML = xDoc.Root.Elements("user").ToList();
                foreach (XElement xElem in listXML)
                {
                    string userName = xElem.Element("userName").Value;
                    string password = xElem.Element("password").Value;
                    string role = xElem.Element("role").Value;
                    User ut = new User(userName, password, role);
                    listUser.Add(ut);
                }
                return listUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User List Error! " + ex.ToString());
                return null;
            }
        }
        //XML user conditioned data fetch one parameter handling
        public List<User> FilterUser(string roleSearch)
        {
            try
            {
                List<User> listUser = new List<User>();
                XDocument xDoc = XDocument.Load(@"users.xml");
                List<XElement> listXML = xDoc.Root.Elements("user").ToList();
                foreach (XElement xElem in listXML)
                {
                    string role = xElem.Element("role").Value;
                    if (role.ToUpper() == roleSearch.ToUpper())
                    {
                        string userName = xElem.Element("userName").Value;
                        string password = xElem.Element("password").Value;
                        User ut = new User(userName, password, role);
                        listUser.Add(ut);
                    }
                }
                return listUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Filter Error! " + ex.ToString());
                return null;
            }
        }
    }
}
