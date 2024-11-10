using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace sec_a_desktop_app_started.Controller
{
    internal class DBContext
    {

        public string connString()
        {
            string connString = @"Server = VA-OZVSMQR3C0GP\MANISH_RESEARCH; Database = testing; Trusted_Connection = True";

            return connString;
        }

        public int GetID(string query)
        {
            var connectString = connString();
            using (SqlConnection conn = new SqlConnection(connectString))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                string getRawID = cmd.ExecuteScalar().ToString();
                if (getRawID == "")
                {
                    getRawID = "0";
                }
                int id = int.Parse(getRawID) + 1;
                conn.Close();
                return id;
            }
        }

        //public SqlConnection getConn()
        //{
        //    var connectString = connString();
        //    using (SqlConnection conn = new SqlConnection(connectString))
        //    {

        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        return cmd;
        //    }
        //}

        public DataSet getAll(string query)
        {

            var connectString = connString();
            using (SqlConnection conn = new SqlConnection(connectString))
            {

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                return ds;
            }

        }

        public void ExecuteQuery(string query)
        {

            var connectString = connString();
            using (SqlConnection conn = new SqlConnection(connectString))
            {

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, conn);

                // 2. Call ExecuteNonQuery to send command
                conn.Open();
                cmd.ExecuteNonQuery();
                //cmd.
                conn.Close();

            }

        }

        //public void deleteData(string query)
        //{
        //	var connectString = connString();
        //	using(SqlConnection conn = new SqlConnection( connectString))
        //	{
        //		SqlCommand cmd = new SqlCommand(query, conn);

        //		conn.Open();
        //		cmd.ExecuteNonQuery();
        //		conn.Close();
        //	}
        //}
    }
}
