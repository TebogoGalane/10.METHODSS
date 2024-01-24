using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10.METHODSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayHiUser("Tebogo");

            SayHiAge("Ona", 55);
            Console.ReadLine();



        }
        private static void SayHi()
        {
            Console.WriteLine("hi");
       
        }
    private static void SayHiUser(string name)
        {
            Console.WriteLine("hello " + name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("hello " + name + " you are " + age);
        }
      


      
        

    }
}
