using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Proram
    {
        static void Main(string[] args)
        {
            string msg;
            int count;
            Console.Write("your massege: ");
            msg = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the number of repetitions ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
