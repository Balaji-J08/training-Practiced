using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOnet1
{
    class read
    {
        static void Main(string[] args)
        {
            SqlConnection con= null;
            try
            {

                con = new SqlConnection("data Source =DELL\\SQLEXPRESS; database=Student; integrated security=SSPI");
                SqlCommand sc = new SqlCommand("select * from Student",con);

                con.Open();
               SqlDataReader scr =sc.ExecuteReader();

                while(scr.Read())
                {

                    Console.WriteLine("id: " + scr["id"] +"==>"+ "Name: " +scr["name"] +" ==> " + "Mail: "+scr["email"]+ " ==> " + "Date Of Joining: "+scr["join_date"]);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("all data retrieved Successfully");


            }
            catch (Exception e)
            {

                Console.WriteLine("oops something went wrong"+e);
            }
            finally
            {
                con.Close();

            }
            Console.ReadLine();

        }

    }
}
