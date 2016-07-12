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
            string require_an="aeiolnfshrmx";
            name=Console.ReadLine();
            string a_name="a";
            for(int i=0;i<name.Length;i++){
                for(int j=0;j<require_an.Length;i++){
            // foreach(char element in name){
                    if(name[i]== require_an[j]){
                        a_name= "an";
                    }
                }
                Console.WriteLine("give me " + a_name +" "+ name[i]);
            }
            Console.WriteLine(name.ToUpper() + " is granted.");
        }
    }
}
