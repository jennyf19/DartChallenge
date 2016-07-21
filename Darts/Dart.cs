using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    //reusable Dart class
    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }

        private Random  _random;

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0, 21);
            //variable to hold the random number
            int multiplier = _random.Next(1, 101);
            //5% chance
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;
        }
    }
}
