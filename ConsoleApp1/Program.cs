using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcesor();
            var order = new OrderedParallelQuery { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.process(order);
        }
    }
}
