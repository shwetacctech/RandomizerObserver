using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerObserver
{
    internal interface IRandomNumberGenerator
    {
        void GenerateRandomNumbers();
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}
