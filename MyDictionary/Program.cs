using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            Console.WriteLine(dictionary.Count);
            dictionary.Add(3, "burak");
            Console.WriteLine(dictionary.Count);
            Console.ReadLine();

        }
    }
}
