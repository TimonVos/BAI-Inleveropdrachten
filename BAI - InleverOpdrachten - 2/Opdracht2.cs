using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI___InleverOpdrachten___2
{
    public static class Opdracht2
    {
        public static HashSet<uint> Alle(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            set = inputStroom.ToHashSet();
            return set;
        }
        public static HashSet<uint> ZonderLicht(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            foreach (var item in inputStroom)
            {
                if (Opdracht1.Licht(item))
                {
                    inputStroom.Remove(item);
                }
            }
            set = inputStroom.ToHashSet();
            return set;
        }
        public static HashSet<uint> MetWagon(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            foreach (var item in inputStroom)
            {
                if (!Opdracht1.Wagon(item))
                {
                    inputStroom.Remove(item);
                }
            }
            set = inputStroom.ToHashSet();
            return set;
        }
        public static HashSet<uint> SelecteerID(List<uint> inputStroom, uint lower, uint upper)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            foreach (var item in inputStroom)
            {
                if (Opdracht1.ID(item) > lower && Opdracht1.ID(item) < upper)
                {
                    
                }
                else
                {
                    inputStroom.Remove(item);
                }
            }
            set = inputStroom.ToHashSet();
            return set;
        }
    }
}
