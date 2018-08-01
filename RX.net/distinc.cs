using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace Rx1.Properties
{
    class distinc
    {



        static void WhereExample()
        {
            var oddNumbers = Observable.Range(0, 10)
                .Where(i => i % 2 == 0)
                .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
        }
        static void DistinctExample()
        {
            var subject = new Subject<int>();
            var distinct = subject.Distinct();
            subject.Subscribe(
                i => Console.WriteLine("{0}", i),
                () => Console.WriteLine("Subject.OnCompleted()"));
            distinct.Subscribe(
                i => Console.WriteLine("distinct.OnNext({0})", i),
                () => Console.WriteLine("distinct.OnCompleted()"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(1);
            subject.OnNext(1);
            subject.OnNext(4);
            subject.OnCompleted();

        }
        static void DistinctUntilChangeExample()
        {
            var subject = new Subject<int>();
            var distinct = subject.DistinctUntilChanged();
            subject.Subscribe(
                i => Console.WriteLine("{0}", i),
                () => Console.WriteLine("Subject.OnCompleted()"));
            distinct.Subscribe(
                i => Console.WriteLine("distinct.OnNext({0})", i),
                () => Console.WriteLine("distinct.OnCompleted()"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(1);
            subject.OnNext(1);
            subject.OnNext(4);
            subject.OnCompleted();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Example of where......");
            WhereExample();
            Console.WriteLine();
            Console.WriteLine("Example of Distinct......");
            DistinctExample();
            Console.WriteLine();
            Console.WriteLine("Example DistinctUntilChange......");
            DistinctUntilChangeExample();
            Console.ReadKey();
        }
    }
}

