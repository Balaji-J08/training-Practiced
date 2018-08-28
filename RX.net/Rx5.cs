using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx5
    {
        public static void ReplaySubjectBuffer()
        {
            var buffersize = 2;
            var subject = new ReplaySubject<string>(buffersize);
            subject.OnNext("one");
            subject.OnNext("Two");
            subject.OnNext("Three");
            subject.OnNext("Four");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("!");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void Main(string[] args)
        {
            ReplaySubjectBuffer();
            Console.ReadKey();
        }
    }
}
