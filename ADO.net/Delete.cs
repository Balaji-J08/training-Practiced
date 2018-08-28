using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOnet1
{
    class Delete
    {
        static void Main(string[] args)
        {

            SqlConnection con = null;
            try
            {


                con = new SqlConnection("Data Source=DELL\\SQLEXPRESS; database=Student; integrated security=SSPI");
                SqlCommand sc = new SqlCommand("Delete from student where id='100'",con);

                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("Deleted Succesfully");



            }
            catch (Exception e)
            {

                Console.WriteLine("ooops something went wrong" +e);
            }
            finally
            {
                con.Close();


            }
            Console.ReadLine();
            


        }
                    
    }
}
