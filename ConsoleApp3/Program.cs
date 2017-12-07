using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            int k;
            for (k = 0; k < listing.Count; k++)
            Console.Write(listing[k] + " ");

            Console.ReadKey();

        }
    }
}
