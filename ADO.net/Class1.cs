using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet1
{
    

        public partial class Class1 
        {
        static void Main(string[] args)
        {




           void Page_Load(object sender, EventArgs e)
            {
                using (SqlConnection con = new SqlConnection("data source=.; database=Student; integrated security=SSPI"))
                {
                    SqlDataAdapter sde = new SqlDataAdapter("Select * from Student", con);
                    DataSet ds = new DataSet();
                    sde.Fill(ds);
                    Console.WriteLine("ggg");




                    //Populate dataset here
                    //Iterate throuh datatables inside the dataset
                    for (int i = 0; i < ds.Tables.Count; i++)
                    {
                        DataTable temptable = ds.Tables[i]; // this will give you the datatable in each iteration level
                                                            //Do your doce here
                        Console.WriteLine(ds.Tables[i].ToString());
                    }


                }
            }
            Console.ReadKey();

        }
    }
}
