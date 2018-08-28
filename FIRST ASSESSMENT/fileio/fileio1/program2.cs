using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileio
{
    class program2
    {
        static void Main(string[] args)
        {

            DirectoryInfo directory = new DirectoryInfo("E:\\biz");
            try
            {

                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }

                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
            Console.ReadKey();
        }

    }
                    
                    



    }

