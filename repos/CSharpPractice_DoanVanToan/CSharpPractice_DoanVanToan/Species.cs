using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_DoanVanToan
{
    class Species : Animal
    {
        protected int NumberOfLeg;
        public Species()
        {
            this.Name = "I am a species";

        }
        public Species(string name) : base(name)
        {
        }
        public Species(String name, int age, String Color, int numberOfLeg) : base(name)
        {
            this.Age = age;
            this.Color = Color;
            this.NumberOfLeg = numberOfLeg;
        }
        public override void SayHello()
        {
            Console.WriteLine("Species hello every body");
        }
        public override string ToString()
        {
            return base.ToString() + " NumberOfLeg: " + this.NumberOfLeg;
        }
        public static Species operator +(Species species1, Species species2)
        {
            var TempSpecies = new Species();
            TempSpecies.Name = species1.Name + species2.Name;
            TempSpecies.Color = species1.Color + species2.Color;
            TempSpecies.NumberOfLeg = species1.NumberOfLeg > species2.NumberOfLeg ? species1.NumberOfLeg : species2.NumberOfLeg;
            TempSpecies.Age = 1;
            return TempSpecies;
        }
    }
}
