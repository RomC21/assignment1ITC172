using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarPage : System.Web.UI.Page
{
    string[,] events = new string[7, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
       
        events[0, 0] = "Projects Due";
        events[0, 1] = "6/18/2017";
        events[1,0] = "Dinner With Family";
        events[1, 1] = "6/18/2017";
        events[2, 0] = "Watch Wonder Woman";
        events[2, 1] = "6/20/2017";
        events[3, 0] = "Hiking Day";
        events[3, 1] = "6/21/2017";
        events[4, 0] = "Job Interview";
        events[4, 1] = "6/23/2017";
        events[5, 0] = "Seattle Pride Parade";
        events[5, 1] = "6/25/2017";
        events[6, 0] = "Keith Brock 4th Party";
        events[6, 1] = "7/1/2017";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        string myDate = Calendar1.SelectedDate.ToShortDateString();
        //string birthday = "5/9/2017";
        Label1.Text = DateTime.Now.ToString();

        for (int i = 0; i < 5; i++)
        {
            if (myDate.Equals(events[i,1]))
            {
                Label1.Text += events[i,0] + "<br/>";
            }
        }
        
        //
    }
    
}



