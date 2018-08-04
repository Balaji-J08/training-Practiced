using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOnet1
{
    class TableCreat
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source=DELL\\SQLEXPRESS; integrated security=SSPI");
                DataTable tc = new DataTable("ROYAL");
            tc.Columns.Add("ID");
            tc.Columns.Add("Name");
            tc.Columns.Add("job");
            tc.Rows.Add("100", "Balaji", "Engineer");
            tc.Rows.Add("101", "Royal", "bike");
            tc.Rows.Add("102", "Bullet", "Bike");
            tc.Rows.Add("103", "Commando", "Bike from US");
            tc.Rows.Add("104", "Thunder", "Bike from Royal");

                //DataSet ds = new DataSet();
                //SqlDataAdapter sde = new SqlDataAdapter("Select * from Student", con);
                //sde.Fill(ds);
                //Console.WriteLine("DataSet Object is filled by sql Data adapter");



                //Console.WriteLine("Number of Rows are: " + ds.Tables[0].Rows.Count + " and  Number of Columns are: " + ds.Tables[0].Columns.Count);
                //Console.WriteLine();
                //Console.WriteLine();

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    Console.WriteLine();
                //    Console.WriteLine();
                //    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                //    {
                //        Console.Write("  " + ds.Tables[0].Rows[i][j].ToString() + "  ");
                //    }
                //}

                Console.WriteLine("Done");

        }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();




    }



    }
}
