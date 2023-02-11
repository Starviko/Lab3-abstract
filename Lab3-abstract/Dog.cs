using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    internal class Dog:Animal
    {
        protected string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat beef.");
        }
    }
}
