using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx7
    {
        static void Subject(Subject<string> subject)
        {
            WriteSequenceToConsole(subject);
            subject.OnNext("Going");
            subject.OnNext("To");
            subject.OnNext("UK");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            Subject(subject);
            Console.ReadKey();
        }
    }
}
