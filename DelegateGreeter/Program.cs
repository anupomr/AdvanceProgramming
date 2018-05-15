using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGreeter
{
    enum GreeterEnum { HI, BYE };
    //Steep 2
     delegate void Greeter(GreeterEnum greeting = GreeterEnum.HI);
    class Program
    {
        static void Main(string[] args)
        {
            Greeter newGreeter = Frence;
            newGreeter();
            newGreeter += new Program().English;
            newGreeter();

            
        }
        static void Frence(GreeterEnum greet)
        {
            Console.WriteLine(greet == GreeterEnum.HI ? "Bonjour" : "Au revoir");
        }
        public void English(GreeterEnum greet)
        {
            Console.WriteLine(greet == GreeterEnum.HI ? "HI" : "BYE");
        }

        public void Portugese(GreeterEnum greet) => Console.WriteLine(greet == GreeterEnum.HI ? "Ola" : "Tchau");

        public void Punjabi(GreeterEnum greet) => Console.WriteLine(greet == GreeterEnum.HI ? "Sat sri Akal" : "Tata");

        public void Bangladesh(GreeterEnum greet) => Console.WriteLine(greet == GreeterEnum.HI ? "Aija" : "Tata");

        
    }
}
