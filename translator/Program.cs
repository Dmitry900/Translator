using System;

namespace translator
{
    class Program
    {
        static void Main()
        {
            StaticTables staticTables = new StaticTables("Service_Words.txt");
            for (int i = 0; i < 12; i++)
                Console.WriteLine(staticTables.GetName(i+1));
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(staticTables.GetName(12));
            Console.WriteLine(staticTables.GetNumber(";"));
            Console.ReadLine();
        }
    }
}
