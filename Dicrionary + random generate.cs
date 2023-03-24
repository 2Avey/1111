using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> arrayDict = new Dictionary<int, int>();

            Console.Write("how mcuh dictionary elements create?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand= new Random();

            for (int i = 0; i < n; i++)
            {
                int random = rand.Next(-1000, 1000);
                arrayDict.Add(i, random);
            }
            foreach (var item in arrayDict)
            {
                Console.WriteLine($"{item.Key} - index | {item.Value} - value |");
                //var Total = arrayDict.Sum(x => x.Value);
                //Total += arrayDict.Count;
            }
        }
        
    }
}
