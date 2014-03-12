using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace DelegateBoard_Project2
{
    public abstract  class ListUserControl : System.Web.UI.UserControl
    {
        public abstract void RowFormatter(IDataRecord row, List<ListModel> model);

        public virtual DataAccess.FormatListRow ListFormatter
        {
            get { return new DataAccess.FormatListRow(RowFormatter); }
        }
    }
}