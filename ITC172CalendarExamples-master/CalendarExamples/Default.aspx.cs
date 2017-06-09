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
        //if(IsPostBack==false)
       // {
              string[,] events = new string[5, 2];
          events[0, 1] = "Projects Due";
          events[0, 1] = "Dinner With Family";
          events[1, 1] = "Openning Day for MLB";
          events[2, 0] = "Movie Day";
          events[2, 1] = "Hiking Day";
          events[3, 0] = "Moving Day";
          events[3, 1] = "Registration For School";
          events[4, 0] = "Job Interview";
          


        //if (IsPostBack == false)
            //FillAuthor();
       // }

    }

    //protected void FillAuthor()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        EventsDropDownList.Items.Add(events[i, 0]);
    //    }
    //    ListItem item = new ListItem("Choose an Events");
    //    EventsDropDownList.Items.Insert(0, item);
    //}

    //protected void EventsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ResultLabel.Text = "";
    //    string events;
    //    events = EventsDropDownList.SelectedItem.Text;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        if(events[i,0].Equals(events))
    //        {
    //            ResultLabel.Text += events[i, 1] + "<br/>";
    //        }
    //    }

    //}
}