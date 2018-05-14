using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //Steep 2
    public delegate void Signee();
    class Program
    {
        static void Main(string[] args)
        {
            //Steep 3
            Signee artist1 = new Signee(Picasso);
            Signee artist2 = JamesDelegate.David;
            Signee vangough = new Program().Vangough;
            //Step 4 invocking delegate
            artist1();
            artist2();
            artist1 += new Program().Vangough;
            artist1();
            Console.WriteLine("**************");
            artist1 += vangough;

            artist1 += () => Console.WriteLine("Done by unknown");
        }
        //Steep 1
        static void Picasso()
        {
            Console.WriteLine("Daone by Picasso");
        }
        void Vangough()
        {
            Console.WriteLine("Done by Vangough");
        }
    }
    class JamesDelegate
    {
        public static void David()
        {
            Console.WriteLine("Done by david");
        }
        public void Rajandeep()
        {
            Console.WriteLine("By Rajandeep");
        }
    }
}
