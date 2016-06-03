using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._6
{
    public class Animal
    {
        String name;
        private int timestamp;

        public String getName() { return this.name; }
        public int getTimestamp() { return this.timestamp; }
        public void setTimestamp(int timestamp) { this.timestamp = timestamp; }

        public Boolean isOlder(Animal a) {
            return this.timestamp > a.timestamp;
        }

        public Animal(String name) {
            this.name = name;
        }
    }

    public class Dog : Animal {
        public Dog(String name) : base(name) { }
    }

    public class Cat : Animal {
        public Cat(String name) : base(name) { }
    }
}
