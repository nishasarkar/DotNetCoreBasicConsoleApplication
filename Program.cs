using System;
using System.Collections;

namespace FirstApp
{
    class program
    {
        static void Main(string[] args) {


            // PrintText();
            // PrintList();

            PrintArrayList();



        }

       private static void PrintText()
        {
            Console.WriteLine("HELLO WORLD!");
            Console.ReadKey();
        }

       private static void PrintList()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            foreach (var item in list)
            {
                Console.WriteLine(item);  
            }
            Console.ReadKey();
        }

        private static void PrintArrayList()
        {
            List<int> list = new List<int>();//TYPE OF DATA FIXED
            list.Add(10);
            list.Add(20);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            ArrayList arrayList = new ArrayList();//HERE THE TYPE OF DATA IS NOT FIXED
            arrayList.Add(10);
            arrayList.Add("nisha");
            foreach (var itemarry in arrayList)
            {
                Console.WriteLine(itemarry);
            }
            Console.ReadKey();
        }
    }
}