using System;
using System.Collections.Generic;

namespace fourth_excersise.utils
{
    public static class Utils
    {
        public delegate bool MyDelegate(int num); 

        public static bool isEven(int num) {
            return num % 2 == 0;
        }

        private static MyDelegate MyLinqFunc = isEven;

        public static List<int> Pares(this List<int> list)
        {
            return list.FindAll(num => MyLinqFunc(num));
        }
    }
}