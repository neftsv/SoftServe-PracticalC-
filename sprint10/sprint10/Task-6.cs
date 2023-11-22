using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint10_Task6
{
    interface IFlyable
    {
        void Fly();
    }

    interface IEating
    {
        void Eat();
    }

    interface IMoving
    {
        void Move();
    }

    interface IBasking
    {
        void Bask();
    }

    interface IKryaking
    {
        void Krya();
    }

    class Bird : IFlyable, IEating, IMoving
    {
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
        public void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }
    }

    class Cat : IBasking, IEating, IMoving
    {
        public void Move()
        {
            Console.WriteLine("I can jump!");
        }

        public void Eat()
        {
            Console.WriteLine("Oh! My milk!");
        }

        public void Bask()
        {
            Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }
    }

    class Parrot : Bird, IKryaking, IBasking
    {
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }

        public void Bask()
        {
            Console.WriteLine("Chuh-Chuh-Chuh...");
        }

        public void Eat()
        {
            Console.WriteLine("Oh! My seeds and fruits!");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }

        public void Krya()
        {
            Console.WriteLine("Krya-Krya-Krya...");
        }
    }

    class Duck : Bird, IEating, IKryaking
    {
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }

        public void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }

        public void Krya()
        {
            Console.WriteLine("Krya-Krya!");
        }

        public void Move()
        {
            Console.WriteLine("I can swimm!");
        }
    }
}
