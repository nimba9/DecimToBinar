using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp06DecimToBinar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number: ");


            string userInp = Console.ReadLine();
            int num = 0;

            bool check = int.TryParse(userInp, out num);

            if (check != true)
            {
                Console.WriteLine("Please enter a positive integer");

            }
            Console.WriteLine("the number is {0}", num);

            int division = 0;

            string remainder = string.Empty;

            while (num >= 1)

            {
                division = num / 2;
                remainder += (num % 2).ToString();
                num = division;
            }

            string binary = string.Empty;

            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                binary = binary + remainder[i];
            }

            Console.WriteLine("The binary version of the entered number is {0}", binary );
        }
    }
}
