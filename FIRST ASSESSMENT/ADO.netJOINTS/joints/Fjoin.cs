using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet1
{
    class Fjoin
    {

        static void Main(string[] args)
        {




            try
            {
                SqlConnection con = new SqlConnection("data source=DELL\\SQLEXPRESS; database=Student; integrated security=SSPI");

                SqlDataAdapter sde = new SqlDataAdapter("select Student.id, Student.name, Result.grade FROM Student FULL OUTER JOIN Result ON Result.id = Student.id", con);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                Console.WriteLine("DataSet Object is filled by sql Data adapter");

                //select Student.id  Student.name Result.grade
                //FROM Student
                //INNER JOIN Student ON Student.id = Result.id

                Console.WriteLine("Number of Rows are: " + ds.Tables[0].Rows.Count + " and  Number of Columns are: " + ds.Tables[0].Columns.Count);
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        Console.Write("  " + ds.Tables[0].Rows[i][j].ToString() + "  ");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }



    }
}
