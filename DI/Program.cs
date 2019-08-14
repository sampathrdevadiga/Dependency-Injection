using System;

namespace DI
{
    /// <summary>
    /// This program explains how Dependency Injection and Inversion of Control Works
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();

            //injecting OrangeStorage class to Add method
            fruit.Add(new OrangeStorage());
        }
    }
    public class Fruit
    {
        IStorage storage;
        public void Add(IStorage storage)
        {
           this.storage = storage;
            storage.Add(this);
        }
    }

    // This interface implements Add method to store fruits
    public interface IStorage
    {
        void Add(Fruit fruit);
    }

    //These storage classes executed according to the fruit class injected in the program class
    class AppleStorage  : IStorage
    {
        public void Add(Fruit fruit)
        {
            Console.WriteLine("Apple Stored!");
            Console.ReadLine();
        }
    }

    class OrangeStorage : IStorage
    {
        public void Add(Fruit fruit)
        {
            Console.WriteLine("Orange Stored!");
            Console.ReadLine();
        }
    }
}
