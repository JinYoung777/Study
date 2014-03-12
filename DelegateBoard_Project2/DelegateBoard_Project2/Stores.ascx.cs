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
    public partial class Stores : ListUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            repeater1.DataSource = DataAccess.GetData("Stores", ListFormatter);
            repeater1.DataBind();
        }

        public override void RowFormatter(IDataRecord row, List<ListModel> model)
        {
            //ListModel rowModel = new ListModel();
            //rowModel.Title = row["Stor_Name"].ToString();
            //rowModel.Content = row["Stor_Address"].ToString();

            //model.Add(rowModel);

            model.Add(new ListModel { Title1 = "Stor_Name2", Content1 = "Stor_Address2" });
            

            
        }
    }
}