using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    class Tiger : Animal
    {
        public Tiger():base() { }
        public Tiger(string name, int age, string description) :base(name,age,description)
        {

        }

        public override string Speak()
        {
            return "Tiger Speak...";
        }

    }

    class Dog : Animal
    {
        public Dog():base() { }
        public Dog(string name, int age, string description) : base(name, age, description) {}

        public override string Speak()
        {
            return "Dog Speak...";
        }
    }

    class Cat : Animal
    {
        public Cat():base() { }
        public Cat(string name, int age, string description) : base(name, age, description)
        {

        }

        public override string Speak()
        {
            return"Cat Speak...";
        }
    }
}
