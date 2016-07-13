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
            Console.WriteLine("What's your birthday?");
            Console.Write(">");
            string the_birthday;
            the_birthday=Console.ReadLine();

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
            DateTime thisDay = DateTime.Today;
            // string thisDay2=String.Format("{0:d}",thisDay);
            // Console.Write(thisDay2);
            DateTime con_birthday=Convert.ToDateTime(the_birthday);
            // string con_birthday2=String.Format("{0:d}",con_birthday);
            // Console.Write(con_birthday);
            TimeSpan t=con_birthday-thisDay;
            Console.WriteLine("Your birthday is "+ t.Days+ " day(s) away!");
        }
    }
}
