//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kattis
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            string line = Console.ReadLine();
//            while (!string.IsNullOrEmpty(line))
//            {
//                decimal sum = 0;
//                decimal prod = 1;
//                Dictionary<char, decimal> WordCount = new Dictionary<char, decimal>();
//                foreach (char c in line)
//                {
//                    if (WordCount.ContainsKey(c))
//                        WordCount[c]++;
//                    else
//                        WordCount.Add(c, 1);
//                }
//                foreach (var elt in WordCount)
//                {
//                    sum += elt.Value;
//                    prod *= factoriel(elt.Value);
//                }
//                Console.WriteLine(String.Format("{0:F0}", factoriel(sum) / prod));
//                line = Console.ReadLine();

//            }
//        }
//        static decimal factoriel(decimal param)
//        {
//            if (param == 1)
//                return 1;
//            else return param * factoriel(param - 1);
//        }
//    }
//}
