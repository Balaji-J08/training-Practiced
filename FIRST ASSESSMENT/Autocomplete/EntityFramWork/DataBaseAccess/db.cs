
using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Data;

using System.Data.SqlClient;

using System.Configuration;

namespace EntityFramWork.DataBaseAccess
{
    public class db
    {


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);



            public DataSet GetName(string prefix)

            {

                SqlCommand com = new SqlCommand("Select * from Student where Name like '%'+@prefix+'%'", con);

                com.Parameters.AddWithValue("@prefix", prefix);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(ds);

                return ds;

            }

        }

    }

