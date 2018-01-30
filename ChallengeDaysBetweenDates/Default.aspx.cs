using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstdate = Calendar1.SelectedDate.Date;
            DateTime seconddate = Calendar2.SelectedDate.Date;
            if  ( firstdate < seconddate)
                {
                TimeSpan daterange = ( seconddate - firstdate);
                resultLabel.Text = daterange.TotalDays.ToString();
                }
            else
                {
               TimeSpan daterange = ( firstdate - seconddate);
                resultLabel.Text = daterange.TotalDays.ToString();
            }

            

           
        }
    }
}