using System;
using System.Collections.Generic;

namespace BAI___InleverOpdrachten___2
{
    public class Program
    {      
            public static void ToonInfo(uint b)
            {
                Console.WriteLine($"ID {Opdracht1.ID(b)}, Licht {Opdracht1.Licht(b)}, Wagon {Opdracht1.Wagon(b)}, Vermogen {Opdracht1.Vermogen(b)}, Vooruit {Opdracht1.Vooruit(b)}");
            }

            public static List<uint> GetInputStroom()
            {
                List<uint> inputStream = new List<uint>();
                for (uint i = 0; i < 256; i++)
                {
                    inputStream.Add(i);
                }
                return inputStream;
            }

            public static void PrintSet(HashSet<uint> x)
            {
                Console.Write("{");
                foreach (uint i in x)
                    Console.Write($" {i}");
                Console.WriteLine($" }} ({x.Count} elementen)");
            }


            static void Main(string[] args)
            {
                Console.WriteLine("=== Opgave 1 ===");
                ToonInfo(210);
                Console.WriteLine();

                List<uint> inputStroom = GetInputStroom();

                Console.WriteLine("=== Opgave 2 ===");
                HashSet<uint> alle = Opdracht2.Alle(inputStroom);
                PrintSet(alle);
                HashSet<uint> zonderLicht = Opdracht2.ZonderLicht(inputStroom);
                PrintSet(zonderLicht);
                HashSet<uint> metWagon = Opdracht2.MetWagon(inputStroom);
                PrintSet(metWagon);
                HashSet<uint> groter6 = Opdracht2.SelecteerID(inputStroom, 6, 7);
                PrintSet(groter6);
                Console.WriteLine();

                Console.WriteLine("=== Opgave 3a ===");
                HashSet<uint> opg3a = Opdracht3.Opg3a(inputStroom);
                PrintSet(opg3a);
                foreach (uint b in opg3a)
                {
                    ToonInfo(b);
                }
                Console.WriteLine();

                Console.WriteLine("=== Opgave 3b ===");
                HashSet<uint> opg3b = Opdracht3.Opg3b(inputStroom);
                PrintSet(opg3b);
                foreach (uint b in opg3b)
                {
                    ToonInfo(b);
                }
                Console.WriteLine();
            }
        
    }
}
