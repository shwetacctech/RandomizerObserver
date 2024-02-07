using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerObserver
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(int randomNumber)
        {
            foreach (var observer in _observers)
            {
                observer.Update(randomNumber);
            }
        }

        public void GenerateRandomNumbers()
        {
            Random rnd = new Random();
            int matchCount = 0;
            while (matchCount < 3)
            {
                int randomNumber = rnd.Next(1, 11);
                NotifyObservers(randomNumber);
                if (randomNumber == 7) // Example matching number
                {
                    matchCount++;
                }
            }
        }
    }
}
