using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI___InleverOpdrachten___2
{
    public static class Opdracht3
    {
        public static HashSet<uint> Opg3a(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            foreach (var item in inputStroom)
            {
                if (Opdracht1.ID(item) < 3 && !Opdracht1.Licht(item))
                {
                    
                } else
                {
                    inputStroom.Remove(item);
                }
            }
            set = inputStroom.ToHashSet();
            return set;
        }

        public static HashSet<uint> Opg3b(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //

            foreach (var item in inputStroom)
            {
                if (Opdracht1.ID(item) > 2 || Opdracht1.Licht(item))
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
