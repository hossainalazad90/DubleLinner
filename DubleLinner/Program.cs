using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubleLinner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Duble Linner Number:");
            int inputValue =int.Parse(Console.ReadLine());
            var dd = DubleLinner.dblLinear(inputValue);
            Console.WriteLine("dblLinear ({0}) should return {1}", inputValue, dd);
            Console.ReadKey();


        }
        
    }

    public static class DubleLinner
    {
        public static int dblLinear(int n)
        {
            var dictionary = new SortedDictionary<int, int>();
            dictionary.Add(1, 1);
            int x, y, z, aux;

            for (int i = 0; i < n; i++)
            {
                x = dictionary.ElementAt(i).Key;
                y = 2 * x + 1;
                z = 3 * x + 1;

                if (!dictionary.TryGetValue(y, out aux)) dictionary.Add(y, 1);
                if (!dictionary.TryGetValue(z, out aux)) dictionary.Add(z, 1);
            }

            return dictionary.ElementAt(n).Key;
        }
    }
}
