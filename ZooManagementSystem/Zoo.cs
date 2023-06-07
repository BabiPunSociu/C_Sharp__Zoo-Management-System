using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    internal class Zoo
    {
        public List<Cage> CageList = new List<Cage>();

        public void AddCage(Cage c) // add a cage to CageList
        {
            CageList.Add(c);
        }
        public void RemoveCage(int c) // remove a cage has CageNumber c from CageList
        {
            foreach (Cage cage in CageList)
            {
                if (cage.CageNumber == c)
                {
                    CageList.Remove(cage);
                    Console.WriteLine("=== Done ===");
                    break;
                }
            }
        }

        public void addAnimalToCage(int c)
        {
            for (int i = 0; i < CageList.Count; i++)
            {
                if (CageList[i].CageNumber == c)
                {
                    CageList[i].AddAnimal();
                    Console.WriteLine("=== Done ===");
                    break;
                }
            }
        }

        public void removeAnimalInCage(int numberCage, string nameAnimal)
        {
            for (int i = 0; i < CageList.Count; i++)
            {
                if (CageList[i].CageNumber == numberCage)
                {
                    CageList[i].RemoveAnimal(nameAnimal);
                    Console.WriteLine("=== Done ===");
                    break;
                }
            }
        }

        public void Display()
        {
            for(int i = 0; i < CageList.Count; i++)
            {
                CageList[i].Display();
            }    
        }
    }
}
