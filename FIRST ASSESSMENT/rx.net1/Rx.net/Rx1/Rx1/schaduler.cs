using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Concurrency;

namespace Rx1
{
    class schaduler
    {
      


        private static void ScheduleTasks(IScheduler scheduler)
        {
            Action leafAction = () => Console.WriteLine("----leafAction.");
            Action innerAction = () =>
            {
                Console.WriteLine("--innerAction start.");
                scheduler.Schedule(leafAction);
                Console.WriteLine("--innerAction end.");
            };
            Action outerAction = () =>
            {
                Console.WriteLine("outer start.");
                scheduler.Schedule(innerAction);
                Console.WriteLine("outer end.");
            };
            scheduler.Schedule(outerAction);
        }
        
    }
}
