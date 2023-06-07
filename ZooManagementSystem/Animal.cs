using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    abstract class Animal
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Description { get; set; }

        public Animal() { }
        public Animal(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }

        public void inputAnimal()
        {
            Console.Write("\nNhap name: ");
            Name = Console.ReadLine();
            Console.Write("\nNhap age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap description: ");
            Description = Console.ReadLine();
        }

        public abstract string Speak();
        public void ViewInfo() // display Name, Age, and Description of the animal
        {
            Console.WriteLine(Name.PadLeft(10) +"|" + Age.ToString().PadLeft(2) + "|" + Description.PadLeft(20) + "|" + Speak());
        }
    }
}
