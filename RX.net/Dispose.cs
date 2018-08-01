using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rx1
{
    class Dispose : IDisposable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal color");
            Dispose d = new Dispose();
            d.ConsoleColor(System.ConsoleColor.Red);
           
        }


            private  ConsoleColor _previousColor;
        public void ConsoleColor(ConsoleColor color)
        {
            _previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }
       

        void IDisposable.Dispose()
        {
            Console.ForegroundColor = _previousColor;
        }
    }

}

  

