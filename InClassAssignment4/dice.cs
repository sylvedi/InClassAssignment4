using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment4
{
    class dice
    {
        private int numSides;
        static Random rnd = new Random();
        //constructor
        public dice(int n)
        {
            numSides = n;
        }

        public int rollDie( )
        {
            return rnd.Next(1, numSides + 1);
        }
    }
}
