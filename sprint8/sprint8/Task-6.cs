using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint8
{
    class PersonInTheShop
    {
        public static void Enter()
        {
            Console.WriteLine("Enter");
        }
        public static void SelectGroceries()
        {
            Console.WriteLine("SelectGroceries");
        }
        public static void Pay()
        {
            Console.WriteLine("Pay");
        }
        public static void Leave()
        {
            Console.WriteLine("Leave");
        }
    }

    class Buyer : PersonInTheShop
    {
        private static int _userInShop = 0;
        private Thread _thread;
        public Buyer(string threadName)
        {
            if (_userInShop < 10)
            {
                Interlocked.Increment(ref _userInShop);
                _thread = new Thread(Shop);
                _thread.Name = threadName;
                _thread.Start();
            }
        }
        private void Shop()
        {
            Enter();
            SelectGroceries();
            Pay();
            Leave();
            Interlocked.Decrement(ref _userInShop);
        }
    }
}
