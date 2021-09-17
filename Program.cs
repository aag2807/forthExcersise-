using System;
using System.Collections.Generic;
using fourth_excersise.utils;


namespace fourth_excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyList = new List<int>(){1,2,3,4,5,6,7,8,9,10};
            var result = MyList.Pares();

            foreach (var item in result)
            {   
                Console.WriteLine(item);
            }
            
            Console.WriteLine("---------------");
            Console.WriteLine(EsImpar(3));
            Console.WriteLine(CalcularITBIS(100));
            Console.WriteLine(GetDate());
            Console.WriteLine("---------------\n ");

        }

        public static Func<int, bool> EsImpar = (int x) => x % 2 != 0;

        public static Func<double, double> CalcularITBIS = (double precio) => precio * 0.18;

        public static Func<DateTime> GetDate = () => DateTime.Now;


        /*
            public bool EsImpar(int x)
            {
                if (x % 2 != 0)
                {
                    return true;
                else
                {
                    return false;
                }
            }


            public double CalcularITBIS(double precio)
            {
                var itebis = precio * 0.18;
                return itebis;
            }


            public void GetDate()
            {
                var fecha = DateTime.Now;
                return fecha;
            }
        */

        
    }
}
