using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    class Program
    {
    /*   1. Add Cage
        2. Remove Cage
        3. Add Animal
        4. Remove Animal
        5. Display all Animals
        6. Exit */
        static void showMenu()
        {
            Console.WriteLine("================== MENU ==================");
            Console.WriteLine("1. Add Cage");
            Console.WriteLine("2. Remove Cage");
            Console.WriteLine("3. Add Animal");
            Console.WriteLine("4. Remove Animal");
            Console.WriteLine("5. Display all Animal");
            Console.WriteLine("6. Exit");
        }

        static int nhapChucNang()
        {
            int chucNang;
            do
            {
                showMenu();
                Console.Write("Lua chon cua ban: ");
                chucNang = Convert.ToInt32(Console.ReadLine());
            }while(chucNang < 1 || chucNang > 6);
            return chucNang;
        }

        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            int chucNang = 1;
            do
            {
                chucNang = nhapChucNang();

                switch(chucNang)
                {
                    case 1:
                        Console.WriteLine("Chuc nang 1: Add Cage.");
                        Cage c = new Cage();

                        c.inputCage();

                        zoo.AddCage(c);
                        break;
                    case 2:
                        Console.WriteLine("Chuc nang 2: Remove Cage.");
                        Console.Write("Nhap number cage: ");
                        int numberRemove = Convert.ToInt32(Console.ReadLine());
                        zoo.RemoveCage(numberRemove);
                        break;
                    case 3:
                        Console.WriteLine("Chuc nang 3: Add Animal.");
                        Console.Write("\nNhap number Cage to add animal: ");
                        int numberCageAddAnimal = Convert.ToInt32(Console.ReadLine());
                        zoo.addAnimalToCage(numberCageAddAnimal);
                        break;
                    case 4:
                        Console.WriteLine("Chuc nang 4: Remove Animal");
                        Console.Write("Nhap CageNumber: ");
                        int numberCage = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nNhap name animal: ");
                        string nameAnimal = Console.ReadLine();
                        zoo.removeAnimalInCage(numberCage, nameAnimal);
                        break;
                    case 5:
                        Console.WriteLine("Chuc nang 5: Display All Animal");
                        zoo.Display();
                        break;
                    case 6:
                        Console.WriteLine("=========== GoodBye ===========");
                        break;
                }    

            } while (chucNang != 6);
        }
    }
}