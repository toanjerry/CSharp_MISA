using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_DoanVanToan
{
    class Cat : Species , IAnimalAction
    {
        private readonly bool IsSleeping = true; 
        public Cat()
        {
            this.NumberOfLeg = 4;
            this.Name = "A cat";
            this.Age = 4;
            this.Color = "white";
        }
        public Cat(string name) : base(name) { }
        public Cat(string name, int age, string color, int numberOfLeg) : base(name, age, color, numberOfLeg)
        {
        }
        public String Running()
        {
            return this.Name + " is running";
        }
        public override void SayHello()
        {
            Console.WriteLine("hello, I am a Cat, my name is " + this.Name);
        }
    }
}
