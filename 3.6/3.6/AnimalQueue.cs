using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._6
{
    class AnimalQueue
    {
        Queue<Dog> dogs = new Queue<Dog>();
        Queue<Cat> cats = new Queue<Cat>();
        int order = 0;

        public void Enqueue(Animal animal) {
            animal.setTimestamp(order);
            if (animal is Dog)
                dogs.Enqueue((Dog)animal);
            else if (animal is Cat)
                cats.Enqueue((Cat)animal);

            order++;
        }

        public Animal DequeueAny() {
            if (dogs.Count == 0)
                return DequeueCat();
            else if (cats.Count == 0)
                return DequeueDog();

            Dog dog = dogs.Peek();
            Cat cat = cats.Peek();

            if (dog.isOlder(cat))
                return DequeueCat();
            else
                return DequeueDog();
        }

        public Dog DequeueDog() {
            return dogs.Dequeue();
        }

        public Cat DequeueCat() {
            return cats.Dequeue();
        }

        public int Size() {
            return dogs.Count + cats.Count;
        }
    }
}
