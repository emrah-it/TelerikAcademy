using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork;
using HomeWork.BinarySearchTree;
namespace Run
{
    class Program

    {
        static void Main(string[] args)
        {
            //TestPerson();
            //TestBitArray();
            TestBinarySearch();
        }

        private static void TestBinarySearch()
        {
            BinarySearchTree newItem = new BinarySearchTree();
            newItem.Add("1");
            newItem.Add("2");
            newItem.Add("3");
            newItem.Add("4");
            newItem.Add("5");
            newItem.Add("6");
            newItem.Add("7");
            newItem.Add("8");
            newItem.Add("9");
            newItem.Add("10");
            newItem.Add("11");

            foreach (var item in newItem)
            {
                Console.WriteLine(item.ItemValue);
            }

            newItem.Remove("4");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in newItem)
            {
                Console.WriteLine(item.ItemValue);
            }
        }

        private static void TestBitArray()
        {
            BitArray64 bitArray = new BitArray64();
            bitArray.Add(1);
            bitArray.Add(2);
            bitArray.Add(13);
            bitArray.Add(14);
            bitArray.Add(15);
            bitArray.Add(16);
            bitArray.Add(18);
            bitArray.Add(19);
            bitArray.Add(10);
            bitArray.Add(18);
            foreach (var item in bitArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestPerson()
        {
            Person first = new Person("Pesho");
            Console.WriteLine(first);
            Person second = new Person("Pesho", 12);
            Console.Write(second);
        }
    }
}
