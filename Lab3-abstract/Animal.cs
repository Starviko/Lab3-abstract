using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    internal abstract class Animal
    {
        private string name;
        private string color;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        //public string Getter()
        //{
        //    return ;
        //}
        //public string Setter()
        //{
        //    return;
        //}
        public abstract void Eat();
    }
}
