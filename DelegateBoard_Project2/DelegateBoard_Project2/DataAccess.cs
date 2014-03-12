using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace DelegateBoard_Project2
{
    public abstract class DataAccess
    {
        public static readonly string ConnectionString = "";// ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public delegate void FormatListRow(IDataRecord row, List<ListModel> model);

        public static List<ListModel> GetData(string table, FormatListRow listRow)
        {
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                //cmd = new SqlCommand(
                //                string.Format("SELECT * FROM {0}", table),
                //                new SqlConnection(ConnectionString));
                //cmd.Connection.Open();
                //reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                List<ListModel> model = new List<ListModel>();

                for (int i = 0; i < 5; i++)
                {
                    listRow(reader, model);
                }
                //while (reader.Read())
                //{
                //    listRow(reader, model);
                //}

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
            //    reader.Close();
            //}
        }
    }
}