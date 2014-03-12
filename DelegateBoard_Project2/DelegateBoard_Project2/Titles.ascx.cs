using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace DelegateBoard_Project2
{
    public partial class Titles : ListUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgList.DataSource = DataAccess.GetData("Titles", ListFormatter);
            dgList.DataBind();
        }

        public override void RowFormatter(IDataRecord row, List<ListModel> model)
        {
            /* ListModel rowModel = new ListModel();
            rowModel.Title = row["Title"].ToString();
            rowModel.Content = row["Notes"].ToString();
             */

            model.Add(new ListModel { Title1 = "Title1", Content1 = "Content1" });
            //model.Add(new ListModel { Title = "Title2", Content = "Content2" });
            //model.Add(new ListModel { Title = "Title3", Content = "Content3" });
            //model.Add(new ListModel { Title = "Title4", Content = "Content4" });
            //model.Add(new ListModel { Title = "Title5", Content = "Content5" });
            //model.Add(new ListModel { Title = "Title6", Content = "Content6" });
        }
    }
}