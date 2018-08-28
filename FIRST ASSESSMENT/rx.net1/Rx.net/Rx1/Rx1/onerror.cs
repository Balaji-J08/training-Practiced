using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;


namespace Rx1
{
    class onerror
    {
        static void Main(string[] args)
        {
                
             var observableSubject = new Subject<int>();
            observableSubject.Subscribe(Console.WriteLine);
            observableSubject.OnNext(1);
            observableSubject.OnCompleted();
            observableSubject.OnNext(2);
            Console.ReadLine();




        }



    }
}
