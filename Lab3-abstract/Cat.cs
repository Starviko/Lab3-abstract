using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    internal class Cat:Animal
    {
        protected string hairStyle;
        public string HairStyle
        {
            get { return hairStyle; }
            set { hairStyle = value; }
        }

        public Cat(string hairStyle)
        {
            this.hairStyle = hairStyle;
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
