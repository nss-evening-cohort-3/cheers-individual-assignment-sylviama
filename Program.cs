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
            //name question
            Console.WriteLine("What's your name?");
            Console.Write(">");
            string name;
            name=Console.ReadLine().ToLower();

            //birthday question
            bool keepGoing=true;
            while(keepGoing){
                Console.WriteLine("What's your birthday?");
                Console.Write(">");
                string the_birthday;
                the_birthday=Console.ReadLine();

                try{
                //birthday calculation 
                DateTime con_birthday=Convert.ToDateTime(the_birthday);
                DateTime thisDay = DateTime.Today;
                TimeSpan t=con_birthday-thisDay;

                //name output
                string require_an="aeiolnfshrmx";
                string a_name="a";
                for(int i=0;i<name.Length;i++){
                    if(require_an.IndexOf(name[i])>-1){
                        a_name= "an";
                    }else{
                        a_name= "a";
                    }
                    Console.WriteLine("give me " + a_name +" "+ name[i]);
                }
                Console.WriteLine(name.ToUpper() + " is granted.");

                //birthday output
                Console.WriteLine("Your birthday is "+ t.Days+ " day(s) away!");
                keepGoing=false;
                
                } catch(FormatException){
                    Console.Write("Birthday input is not valid. ");
                    continue;
                }
            }

            

            

            
        }
    }
}
