using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet1
{
    class ADOnet2
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {

                //SqlCommand cm = new SqlCommand("insert into student  
                //(id, name, email, join_date) values('101','Ronald Trump','ronald@example.com','1/12/2017')", con);  
                con = new SqlConnection("Data Source = DELL\\SQLEXPRESS; Database=Student; integrated security =SSPI");


                SqlCommand sc = new SqlCommand("insert into Result(id, name, grade, result) values('100','balu','A','pass')", con);
               SqlCommand sc1= new SqlCommand("insert into Result  (id, name, grade, result) values('102','Ronald Trump','B','pass')", con);
                SqlCommand sc2 = new SqlCommand("insert into Result(id, name, grade, result) values('103','Royal','C','fail')", con);
                SqlCommand sc3 = new SqlCommand("insert into Result(id, name, grade, result) values('104','Enfield','A','pass')", con);

                con.Open();



                sc.ExecuteNonQuery();
                sc1.ExecuteNonQuery();
                sc2.ExecuteNonQuery();
                sc3.ExecuteNonQuery();
                Console.WriteLine("inserted  succesfully");
            }
            catch(Exception e)
            {

                Console.WriteLine("OOP's got an error..." + e);


            }
            finally
                {
                con.Close();
            }

                Console.ReadLine();


          


        }


    }
}
