using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx3
    {
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void AsyncSubject(AsyncSubject<string> subject)
        {
            subject.OnNext("BYE");
            WriteSequenceToConsole(subject);
            subject.OnNext("to");
            subject.OnNext("All");
            subject.OnCompleted();
            Console.WriteLine("last value will be printed");
        }

     

        static void Main(string[] args)
        {
            var subject = new AsyncSubject<string>();
            AsyncSubject(subject);
           // AsyncSubject1(subject);
            Console.ReadKey();
        }
    }
}
