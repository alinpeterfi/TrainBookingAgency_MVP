using System;
using System.Windows.Forms;
using PS_project12.View;

/*
 Application for train ticket booking agencies. The application has 3 types of users: traveler, employee and administrator.
Passenger-type users can perform the following operations without authentication:
❖ Viewing the list of trains by station of departure, destination, duration;
❖ Viewing the list of trains between 2 locations, including price and availability of free seats;
❖ Search for a train by number.
Employee-type users can perform the following operations after authentication:
❖ All operations allowed to traveling users;
❖ CRUD operations regarding the persistence of trains and tickets sold;
❖ Selling a ticket to a traveler.
Administrator users can perform the following operations after authentication:
❖ All operations allowed to traveling users;
❖ CRUD operations for information related to users of the application that requires authentication
 */


/*
The model defines the data to be displayed or otherwise acted upon in the user interface.
The view is a passive interface that displays data (the model) and routes user commands (events) to the presenter to act upon that data.
The presenter acts upon the model and the view. It retrieves data from repositories (the model), and formats it for display in the view.
 */
namespace PS_project12
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
             Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserV());
        }
    }
}
