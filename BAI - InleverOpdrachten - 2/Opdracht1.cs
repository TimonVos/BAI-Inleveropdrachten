using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI___InleverOpdrachten___2
{
    public static class Opdracht1
    {
        public static bool Vooruit(uint b)
        {
            return Convert.ToBoolean(b & (1 << 7));
        }
        public static uint Vermogen(uint b)
        {
            switch ((b & (0b11 << 5)) >> 5)
            {
                case 0b00:
                    return 0;
                    break;
                case 0b01:
                    return 33;
                    break;
                case 0b10:
                    return 67;
                    break;
                case 0b11:
                    return 100;
                    break;
                default:
                    return 101;
                    break;
            }
        }
        public static bool Wagon(uint b)
        {
            return Convert.ToBoolean(b & (1 << 4));
        }
        public static bool Licht(uint b)
        {
            return Convert.ToBoolean(b & (1 << 3));
        }
        public static uint ID(uint b)
        {
            return b & (0b111 << 0);
        }
    }
}
