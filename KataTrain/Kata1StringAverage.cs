using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTrain
{
    public class Kata1StringAverage
    {
        public string AverageString(string str)
        {
            int average;
            int sumstr = 0;
            int countstr = 0;
            Dictionary<string, int> stringpairInt = new Dictionary<string, int>();
            stringpairInt.Add("zero", 0);
            stringpairInt.Add("one", 1);
            stringpairInt.Add("two", 2);
            stringpairInt.Add("three", 3);
            stringpairInt.Add("four", 4);
            stringpairInt.Add("five", 5);
            stringpairInt.Add("six", 6);
            stringpairInt.Add("seven", 7);
            stringpairInt.Add("eight", 8);
            stringpairInt.Add("nine", 9);
            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            string[] splitstr = str.Split(' ');

            foreach (var a in splitstr)
            {
                if (stringpairInt.ContainsKey(a))
                {
                    sumstr += stringpairInt[a];
                    countstr++;
                }
                else return "n/a";

            }
            average = sumstr / countstr;
            //Linq
            //var resultlist = from a in stringpairInt
            //                 where a.Value == average
            //                 select a.Key;

            //Lambda
            var resultlist = stringpairInt.Where(x => x.Value == average)
                .Select(x => x.Key);

            string result = string.Empty;
            foreach (var a in resultlist)
            {
                result = a;
            }

            return result;

        }
    }
}
