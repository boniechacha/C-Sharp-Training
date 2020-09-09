using System;

namespace SoftNetTraining.Animals
{
    public abstract class Animal
    {
        private string name;

        public abstract void Move();

        public void Eat()
        {
            Console.WriteLine("Eating using mouth");
        }
    }
}