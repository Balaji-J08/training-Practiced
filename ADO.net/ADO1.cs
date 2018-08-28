using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet1
{
    class ADO1
    {
        static void Main(string[] args)
        {
            SqlConnection con= null;
            try
            {
               
                //creating connection
                con = new SqlConnection("Data source=DELL\\SQLEXPRESS; database=employe; integrated Security=SSPI");
                SqlCommand sc = new SqlCommand("create table employe(id int not null,name varchar(50),join_date Date)",con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("Tables created Successfully");


            }
            catch(Exception e)
            {
                Console.WriteLine("OOOP's got an Exception"+ e);
            }



            Console.ReadLine();
        }


    }
}
