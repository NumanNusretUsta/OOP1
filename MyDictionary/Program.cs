using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> iller = new MyDictionary<int, string>();
            iller.Add(1, "Adana");
            foreach (var item in iller.Plakalar)
            {
                Console.WriteLine(item);
            }
            foreach (var item in iller.Iller)
            {
                Console.WriteLine(item);
            }

        }
    }
}
