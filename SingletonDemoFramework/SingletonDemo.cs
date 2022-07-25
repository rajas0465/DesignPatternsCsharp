using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoFramework
{
    public sealed class SingletonDemo
    {
        /*
         * sealed keyword restricts the inheritance
         */
        private static int counter = 0;
        private static SingletonDemo instance = null;
        private static readonly object obj = new object();

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property.
         */
        public static SingletonDemo GetInstance
        {
            get
            {
                if (instance == null)
                {
                    // lock checking of a object is expensive so checking instance before checking lock is will prevent the
                    // unnecessary lock checks. this is called double checking for locks
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new SingletonDemo();
                    }
                }

                return instance;
            }
        }
        /*
         * private constructor ensures that object is not instantiated other than with in
         * tha class itself.
         */
        private SingletonDemo()
        {
            counter++;
            Console.WriteLine("Counter value "+ counter.ToString() );
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
