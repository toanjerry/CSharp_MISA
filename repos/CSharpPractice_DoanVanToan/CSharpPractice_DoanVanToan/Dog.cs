using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_DoanVanToan
{
    class Dog : Species, IAnimalAction
    {
        public Dog()
        {
            this.NumberOfLeg = 4;
            this.Name = "A dog";
            this.Age = 4;
            this.Color = "Black";
        }
        public Dog(string name, int age, string color, int numberOfLeg) : base(name, age, color, numberOfLeg)
        {
        }
        public String Running()
        {
            return this.Name + " is running";
        }
        public override void SayHello()
        {
            Console.WriteLine("hello, I am a dog my name is " + this.Name);
        }
    }
}
