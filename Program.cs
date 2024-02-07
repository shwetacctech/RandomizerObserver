using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();

            Observer observer1 = new Observer(generator);
            Observer observer2 = new Observer(generator);

            generator.Attach(observer1);
            generator.Attach(observer2);

            generator.GenerateRandomNumbers();

            Console.ReadKey();
        }
    }
}
