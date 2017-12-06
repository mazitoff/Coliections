using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Test()
        {
            Console.WriteLine("Test");
        }


        static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.FileFound += Test;
            manager.Search(true);
            manager.FileFound -= Test;
            manager.FileFound -= Test;
            //---------------------------------------
            //manager.FileFound += () => Console.WriteLine("FOUND");
            ////---------------------------------------
            //manager.FileFound += () =>
            //{
            //    Console.WriteLine("FOUND2");
            //};
            ////---------------------------------------
            manager.Search(true);
            Console.WriteLine("*******************************************");
            FileManager2 manager2 = new FileManager2();
            manager2.FileFound2 += Test;
            manager2.FileFound2 += Test;
            manager2.FileFound2 += Test;
            manager.Search(true);
            manager2.FileFound2 -= Test;
            manager2.FileFound2 -= Test;
            manager2.Search2(true);
            Console.WriteLine("*******************************************");

            Action a = () => { Console.WriteLine("1"); };
            a = () => { Console.WriteLine("1"); };
           // manager.FileFound = a;
            manager.FileFound += Test;
            manager.Search(true);
            manager.FileFound -= Test;
            manager.FileFound -= Test;

            Console.ReadKey();

       
        }
    }
}
