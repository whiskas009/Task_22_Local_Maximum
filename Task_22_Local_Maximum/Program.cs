using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_Local_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int [30];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\n\nЛокальные максимумы: \n");

            if (array[0] > array[1])
                Console.WriteLine(array[0]);
            
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i-1] > (array[i-2]) && array[i-1] > array[i])
                    Console.WriteLine(array[i-1]);
            }

            if (array[array.Length-1] > array[array.Length-2])
                Console.WriteLine(array[array.Length-1]);
        }
    }
}
