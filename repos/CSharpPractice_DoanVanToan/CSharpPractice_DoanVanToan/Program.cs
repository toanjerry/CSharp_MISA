using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_DoanVanToan
{
    class Program
    {
        static void Main(string[] args)
        {
            var Species1 = new Species();
            var Dog1 = new Dog();
            var Dog2 = new Dog("Buble", 3, "yellow", 4);
            var Cat1 = new Cat("Moon");
            var Cat2 = new Cat("Lazy", 2, "violet", 3);
            
            Species1.SayHello();
            Species1.ToString();
            Dog1.SayHello();
            Console.WriteLine(Dog1.Running());
            Console.WriteLine(Dog1.ToString());

            Dog2.SayHello();
            Console.WriteLine(Dog2.Running());
            Console.WriteLine(Dog2.ToString());

            Console.WriteLine((Dog1+Dog2).ToString());

            Cat1.SayHello();
            Console.WriteLine(Cat1.Running());
            Console.WriteLine(Cat1.ToString());

            Cat2.SayHello();
            Console.WriteLine(Cat2.Running());
            Console.WriteLine(Cat2.ToString());

            Console.WriteLine((Cat1 + Cat2).ToString());
            Console.WriteLine((Cat1 + Dog2).ToString());
            Console.WriteLine((Cat2 + Dog1).ToString());
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
