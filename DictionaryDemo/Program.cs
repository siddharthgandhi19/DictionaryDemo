using System;
namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            doDictionaryDemo();
        }
        private static void doDictionaryDemo()
        {
           Console.WriteLine("\n doDictionaryDemo");
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=101):" + dictionary[101]);
            Console.WriteLine("\n Iterating Dictionary:");

            foreach(var element in dictionary)
            {
                Console.WriteLine("Key= " +element.Key+" & Value =" + element.Value);
            }
        }
    }
}