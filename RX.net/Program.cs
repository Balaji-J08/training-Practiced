using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;

namespace Rx1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cor = new Cobserver<int>();
            var col = new Cobservable();
            col.Subscribe(cor);
            Console.ReadKey();

        }
    }

        public class Cobserver<T> :IObserver<T>
        {
            public void OnNext(T value)
            {
                Console.WriteLine("Recieved value {0}", value);

            }

            public void OnError(Exception error)
            {
                Console.WriteLine("sequence faulted {0}",error);
            }

            public void OnCompleted()
            {
                Console.WriteLine("Sequence Terminated");
            }

        }



        public class Cobservable :IObservable<int>
    {

        public IDisposable Subscribe(IObserver<int> observer )
        {
            observer.OnNext(1);
            observer.OnNext(20);
            observer.OnNext(30);
            observer.OnCompleted();
            return Disposable.Empty;

        }



    }


    }

