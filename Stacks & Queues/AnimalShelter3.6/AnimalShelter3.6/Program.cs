using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace AnimalShelter3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimalQeue PETCO = new AnimalQeue();
            for (int x = 0;x< 5; x++)
            {
                Dog perro = new Dog();
                perro.setName(x.ToString()+"perro");
                PETCO.enqueueAnimal(perro);
            }
            for (int x = 5; x < 10; x++)
            {
                Cat gato = new Cat();
                gato.setName(x.ToString()+"gato");
                PETCO.enqueueAnimal(gato);
            }

            Console.WriteLine(PETCO.dequeueAny().name);
            Console.WriteLine(PETCO.dequeDog().name);
            Console.WriteLine(PETCO.dequeueAny().name);
            Console.WriteLine(PETCO.dequeCat().name);

        }
    }

    public class AnimalQeue
    {

        LinkedList<Dog> listOfDogs = new LinkedList<Dog>();
        LinkedList<Cat> listOfCats = new LinkedList<Cat>();
        private int order = 0;

        public void enqueueAnimal(Animal animal)
        {
            if(animal is Dog)
            {
                animal.ORDER = order;
                order++;
                listOfDogs.AddLast(animal as Dog);
                
            }else if(animal is Cat)
            {
                animal.ORDER = order;
                order++;
                listOfCats.AddLast(animal as Cat);
            }
        }

        public Animal dequeueAny()
        {
            if(listOfDogs.First.Value.isOlder(listOfCats.First.Value))
            {
                Animal temp = listOfDogs.First.Value;
                listOfDogs.Remove(listOfDogs.First);
                return temp;
            }else
            {
                Animal temp = listOfCats.First.Value;
                listOfCats.Remove(listOfCats.First);
                return temp;
            } 
        }
        public Animal dequeDog()
        {
           
                Animal temp = listOfDogs.First.Value;
                listOfDogs.Remove(listOfDogs.First);
                 return temp;
        }

        public Animal dequeCat()
        {
           
            Animal temp = listOfCats.First.Value;
            listOfCats.Remove(listOfCats.First);
            return temp;
        }
        
    }

    public class Animal
    {
        public string name = String.Empty;
        private int order = 0;


        public void setName(string name)
        {
            this.name = name;
        }

        public int ORDER
        {
            set
            {
                order = value;
            }
            get
            {
                return order;
            }
        }

        public bool isOlder(Animal animal)
        {
            if(this.order<animal.order)
            {
                return true;
            }else
            {
                return false;
            }
        }


    }
    public class Dog:Animal
    {
        
    }

    public class Cat:Animal
    {
        
    }
}
