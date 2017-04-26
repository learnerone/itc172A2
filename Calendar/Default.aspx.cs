using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] events = new string[5, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        events[0, 0] = "4/1/2017";
        events[0, 1] = "The Fools Day";
        events[1, 0] = "4/5/2017";
        events[1, 1] = "Visiting Friends";
        events[2, 0] = "4/8/2017";
        events[2, 1] = "Tutoring Day";
        events[3, 0] = "4/15/2017";
        events[3, 1] = "Registration";
        events[4, 0] = "4/20/2017";
        events[4, 1] = "No Class";

    }

    protected void Calendar_SelectionChanged(object sender, EventArgs e)
    {
        string myDate = Calendar.SelectedDate.ToShortDateString();
        string message = "";
        for (int i = 0; i < 5; i++)
        {
            if (myDate.Equals(events[i, 0]))
            {
                message += events[i, 1];
            }
        }
        if (message.Length == 0)
        {
            message = myDate;
        }
        Label.Text = message;
        
    }


}