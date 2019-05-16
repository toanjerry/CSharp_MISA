using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_DoanVanToan
{
    abstract class Animal
    {
        protected string Name;
        protected int Age;
        protected String Color;
        public Animal()
        {
            this.Name = "An animal";
        }
        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void SayHello();
        public override string ToString()
        {
            return "Name:" + Name + " Age:" + Age + " Color:" + Color;
        }
    }
}
