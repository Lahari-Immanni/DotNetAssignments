using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] MyArray = { "zebra", "Ant", "Owl", "Lion", "Dog" };
            for(int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            foreach(string i in MyArray)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            do
            {
  
                Console.WriteLine(MyArray[j]);
                j++;
            } while (j < MyArray.Length);
            int k = 0;
            while (k < MyArray.Length)
            {
                Console.WriteLine(MyArray[k]);
                k++;
            }
            string[] Animals = { "zensar", "Kiwi", "Amazon Parrot", "Tiger" };
            string[] Places = { "Africa", "NewZealand", "Jamaica", "India" };
            Array.Sort(Animals);
            foreach(string i in Animals)
            {
                Console.WriteLine(i);
            }
            Array.Sort(Places);
            foreach(string i in Places)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
