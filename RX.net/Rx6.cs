using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx6
    {
        public static void ReplaySubjectBuffer()
        {
            var window = TimeSpan.FromMilliseconds(50);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("namsthae");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("helllo every one");
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            subject.OnNext("have a good day");
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
