using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Test
{
    class Kata_1_String_Average
    {
        public static string AverageString(string str)
        {
            string result = "";
            int cal = 0;
            int caldic = 0;
            Dictionary<string, int> mydic = new Dictionary<string, int>();
            mydic.Add("zero", 0);
            mydic.Add("one", 1);
            mydic.Add("two", 2);
            mydic.Add("three", 3);
            mydic.Add("four", 4);
            mydic.Add("five", 5);
            mydic.Add("six", 6);
            mydic.Add("seven", 7);
            mydic.Add("eight", 8);
            mydic.Add("nine", 9);
            if (str == "")
            {
                return "n/a";
            }

            string[] mystr = str.Split(' ');

            foreach (var a in mystr)
            {
                if (mydic.ContainsKey(a))
                {
                    cal += mydic[a];
                    caldic++;
                }
                if (!mydic.ContainsKey(a))
                {
                    return "n/a";
                }
            }
            cal = cal / caldic;
            foreach (KeyValuePair<string, int> kvp in mydic)
            {
                if (kvp.Value == cal)
                {
                    result = kvp.Key;
                }
            }

            return result;

        }
    }
}
