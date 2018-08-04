using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADOnet1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            Console.ReadLine();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            

            try
            {
                //con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                // Creating Connection  
                con = new SqlConnection("data source=DELL\\SQLEXPRESS; database = employe; integrated security=SSPI");//instead we can put integrated security= True
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table employe(id int not null, name varchar(100), email varchar(50), join_date Date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
