using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerObserver
{
    internal class Observer : IObserver
    {
        private RandomNumberGenerator _generator;

        public Observer(RandomNumberGenerator generator)
        {
            _generator = generator;
        }

        public void Update(int randomNumber)
        {
            
            if (randomNumber == 7) 
            {
                Console.WriteLine("Match found!");
            }

        }
       
    }
}
