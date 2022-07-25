using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * assuming singleton is created from employee class
             * we refer to the GetInstance property from the singleton class
             */
            SingletonDemo fromEmp = SingletonDemo.GetInstance;
            fromEmp.PrintDetails("From Employee");

            SingletonDemo fromStu = SingletonDemo.GetInstance;
            fromStu.PrintDetails("From student.");
            
            Console.ReadKey();
        }
    }
}
