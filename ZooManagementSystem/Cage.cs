using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal class Cage
    {
        public int CageNumber;
        public List<Animal> AnimalList = new List<Animal>();
        public void AddAnimal() // add an animal to AnimalList
        {
            Console.WriteLine("input a animal:");

            
            int addNewAnimal = 1;
            do
            {
                Console.Write("Nhap loai dong vat: ");
                string loai = Console.ReadLine();

                if (loai == "Tiger")
                {
                    Tiger tiger = new Tiger();
                    tiger.inputAnimal();
                    AnimalList.Add(tiger);
                }
                else if (loai == "Dog")
                {
                    Dog dog = new Dog();
                    dog.inputAnimal();
                    AnimalList.Add(dog);
                }
                else if (loai == "Cat")
                {
                    Cat cat = new Cat();
                    cat.inputAnimal();
                    AnimalList.Add(cat);
                }
                else
                {
                    Console.WriteLine("Loai " + loai + " chua co trong he thong");
                }

                do
                {
                    Console.Write("\nNhap '1' to add new animal | '0' to stop add new animal. Lua chon: ");
                    addNewAnimal = Convert.ToInt32(Console.ReadLine());
                } while (addNewAnimal < 0 || addNewAnimal > 1);
            } while (addNewAnimal == 1);


        }
        public void RemoveAnimal(string name) // remove an animal has Name “name” from AnimalList
        {
            foreach (Animal a in AnimalList)
            {
                if (a.Name == name)
                {
                    AnimalList.Remove(a);
                    break;
                }
            }
        }
        public void inputCage()
        {
            Console.Write("Nhap CageNumber: ");
            CageNumber = Convert.ToInt32(Console.ReadLine());
            // Nhập AnimalList
            this.AddAnimal();
        }
        public void Display()
        {
            for (int i = 0; i < AnimalList.Count; i++)
            {
                Console.Write(CageNumber.ToString().PadLeft(3) + "|");
                AnimalList[i].ViewInfo();
            }
        }
    }
}
