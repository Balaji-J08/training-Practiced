﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx4
    {
        static void WriteSequenceToconsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void ReplaySubject(ReplaySubject<string> subject)
        {
            subject.OnNext("Hello");
            subject.OnNext("Hello");
            subject.OnCompleted();
            WriteSequenceToconsole(subject);
            subject.OnNext("Reactive");
            subject.OnNext("Programing");
        }
        static void Main(string[] args)
        {
            var subject = new ReplaySubject<string>();
            ReplaySubject(subject);
            Console.ReadKey();
        }
    }
}
