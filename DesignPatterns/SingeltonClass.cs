using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

  /* Singleton design pattern in C# is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.



    Advantages of Singleton Design Pattern: 
    The advantages of a Singleton Pattern are,
    
   1. Singleton pattern can implement interfaces.
   2.Can be lazy-loaded and has Static Initialization.
   3. It helps to hide dependencies.
    4. It provides a single point of access to a particular instance, so it is easy to maintain.
   
    
    Disadvantages of Singleton Design Pattern
    The disadvantages of a Singleton Pattern are,
    
    1.Unit testing is a bit difficult as it introduces a global state into an application
    2.Reduces the potential for parallelism within a program by locking.

    */

    internal sealed class SingeltonClass
    {
        private  static SingeltonClass Instance { get; set; }

        private static object obj; // for loacking of thread
        private SingeltonClass() { }    


        public static SingeltonClass GetInstance()
        {
            lock (obj) // lock the thread so that it cannot be used by other thread
            {
                if (Instance==null)
                {
                    Instance = new();
                }
                return Instance;


            }
        }


    }
}
