using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DelegateBoard_Project2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Control template = null;

            if (((LinkButton)sender).ID == "lnkTitles")
            {
                template = LoadControl("Titles.ascx");
            }
            else if (((LinkButton)sender).ID == "lnkStores")
            {
                template = LoadControl("Stores.ascx");
            }

            this.Controls.Add(template);
        }
    }
}