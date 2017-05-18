using System;
using System.Threading;

namespace VirtualCard
{
    class Randomize
    {
        public static string randomNumber(int number)
        {
            string randomString = "";
            Random NumberRand = new Random();
            for (int i = 0; i < number; i++)
            {
                randomString += NumberRand.Next(0, 9).ToString();
            }
            Thread.Sleep(5);
            return randomString;
        }
    }
}
