using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// чтобы справиться с домашкой я перепрохожу основы. постепенно наверстаю, все сделаю!
// весь код который идет ниже пока что можно не читать, это тренировка.

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
            List<int> listing = new List<int>();
            listing.Add(8);
            listing.Add(13);
            listing.Add(21);
            listing.Add(34);
            listing.Add(709);

            listing.Remove(709);

            int k;
            for (k = 0; k < listing.Count; k++)
            Console.Write(listing[k] + " ");

            Console.Write("Hello, World! ");

            foreach (int element in listing)
                Console.Write(element * 1000 + " ");

            float[] numbers = { 23.4f, 34.45f, 21.23f, 59.67f, 89.27f };
            foreach (float el in numbers)
                Console.Write(el * 1000 + " ");

            Writer("hello, bonjour!");

            List<string> names = new List<string>();
            names.Add("Janet");
            names.Add("Jane");
            names.Add("Jill");
            names.Add("Judy");

            foreach (string name in names)
                Writer("hello, " + name + "!\n");

            Console.WriteLine("введи 2 числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            multiply(num1, num2);

            Console.ReadKey();

        }

        public static void Writer(string strr) {
            Console.WriteLine(strr);
        }

        public static void multiply (int num1, int num2)
        {
            Console.Write("получилось " + num1 * num2);
        }

    }
}
