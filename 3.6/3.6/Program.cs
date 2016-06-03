using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalQueue animalQueue = new AnimalQueue();
            animalQueue.Enqueue(new Dog("one dog"));
            animalQueue.Enqueue(new Dog("two dog"));
            animalQueue.Enqueue(new Cat("three cat"));
            animalQueue.Enqueue(new Cat("four cat"));
            animalQueue.Enqueue(new Dog("five dog"));
            animalQueue.Enqueue(new Cat("six cat"));
            animalQueue.Enqueue(new Cat("seven cat"));
            animalQueue.Enqueue(new Dog("eight dog"));

            Console.WriteLine(animalQueue.DequeueAny().getName());
            Console.WriteLine(animalQueue.DequeueAny().getName());
            Console.WriteLine(animalQueue.DequeueAny().getName());

            animalQueue.Enqueue(new Cat("nine cat"));
            animalQueue.Enqueue(new Dog("ten dog"));

            while (animalQueue.Size() != 0)
                Console.WriteLine(animalQueue.DequeueAny().getName());
        }
    }
}
