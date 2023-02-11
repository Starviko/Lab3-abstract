using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Schanuzer");
            Animal cat = new Cat("long hair");

            dog.Name = "Huhu";
            dog.Age = 1;
            dog.Color = "Brown";
            Console.WriteLine(dog.Name+" is a dog, he is "+dog.Age+" year old and he is "+dog.Color);
            dog.Eat();

            cat.Age = 2;
            cat.Color = "Black";
            cat.Name = "Haha";
            Console.WriteLine(cat.Name + " is a cat, she is " + cat.Age + " years old and she is " + cat.Color);
            cat.Eat();
        }
    }
}
