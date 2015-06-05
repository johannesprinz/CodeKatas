using System;

namespace KarateChop
{
    internal class Karate
    {
        const int unsuccessful = -1;
        public Karate()
        {
        }

        internal int chop(int searchValue, int[] intArray)
        {
            if (intArray == null) return unsuccessful;
            if (intArray.Length > 0 )
            {
                return 0;
            }
      
            return unsuccessful;
        }
    }
}