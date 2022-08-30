using System;

namespace HelperLibrary
{
    public static class RandomNumGen
    {
        //TODO ensure this isnt getting instantiated more than once
        private static readonly Random randy = new Random();

        public static bool GetCoinFlip()
        {
            return randy.Next(0, 2) % 1 == 1;
        }

        public static int GetBetween(int low, int high)
        {
            return randy.Next(low, high);
        }
    }
}