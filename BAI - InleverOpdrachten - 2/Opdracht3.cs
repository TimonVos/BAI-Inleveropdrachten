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
            HashSet<uint> set;

            HashSet<uint> zonderLicht;
            set = Opdracht2.SelecteerID(inputStroom, 0, 2);
            zonderLicht = Opdracht2.ZonderLicht(inputStroom);

            set.IntersectWith(zonderLicht);
            return set;
        }

        public static HashSet<uint> Opg3b(List<uint> inputStroom)
        {
            HashSet<uint> set = Opdracht2.Alle(inputStroom); 
            // *** IMPLEMENTATION HERE *** //
            HashSet<uint> tempSet = Opdracht3.Opg3a(inputStroom);

            set.ExceptWith(tempSet);
            return set;
        }
    }
}
