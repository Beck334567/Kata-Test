using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTrain
{
    class Kata2DeadAnts
    {
        public static int DeadAntsCount(string ants)
        {
            int DeadAntsnumber;
            int antheadnumber = 0;
            int antbodynumber = 0;
            int antfootnumber = 0;
            if (string.IsNullOrEmpty(ants)) return 0;
            ants = ants.Replace("ant", "").Replace(".", "").Replace(" ", "");

            foreach (var pieceofant in ants)
            {
                if (pieceofant == 'a')
                {
                    antheadnumber++;
                }
                else if (pieceofant == 'n')
                {
                    antbodynumber++;
                }
                else if (pieceofant == 't')
                {
                    antfootnumber++;
                }

            }

            DeadAntsnumber = Math.Max(antheadnumber, Math.Max(antbodynumber, antfootnumber));
            return DeadAntsnumber;


        }
    }
}
