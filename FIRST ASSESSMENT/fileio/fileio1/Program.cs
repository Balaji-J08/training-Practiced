using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fileio
{
    class Program
    {
        

            static void Main(string[] args)
            {
                DirectoryInfo dir = new DirectoryInfo("dir");
                if (dir.Exists)
                {
                    dir.Delete();
                    Console.WriteLine("dir deleted sucessfully..");
                }
                else
                {
                    Console.WriteLine("Directory not found ..");
                }
                Console.Read();
            }
        }
    }






