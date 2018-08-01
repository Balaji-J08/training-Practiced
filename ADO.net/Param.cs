using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet1
{
    class Param
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            String inName = "royal";
            SqlDataReader reader = null;
            try
            {
                //SqlConnection con = new SqlConnection("data source=DELL\\SQLEXPRESS; database=Student; integrated security=SSPI");
                con = new SqlConnection("Data source =DELL\\SQLEXPRESS; Database=Student;integrated Security=SSPI");
                SqlCommand sc = new SqlCommand("Select * from Student where name=@name",con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = inName;
                sc.Parameters.Add(param);

                con.Open();
                reader = sc.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("{0},{1}", reader["email"], reader["join_date"]);

                }




            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.ReadLine();



        }


    }
}
