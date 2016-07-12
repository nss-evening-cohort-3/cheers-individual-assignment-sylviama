using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write(">");
            string name;
            name=Console.ReadLine();
            foreach(char element in name)
                Console.WriteLine("give me a "+ element);
            Console.WriteLine(name.ToUpper() + " is granted.");
        }
    }
}
