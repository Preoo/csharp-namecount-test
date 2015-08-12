using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_propportions
{

    public class NamesCount
    {
        private Dictionary<string, int> dicCounts = new Dictionary<string, int>();
        public int count;
        /// <summary>
        /// Adds the name.
        /// </summary>
        /// <param name="name">Name.</param>
        public void AddName(string name)
        {
            int nameCount;
            dicCounts.TryGetValue(name, out nameCount);

            if (nameCount == 0)
            {
                
                dicCounts.Add(name,1);
                count++;

            }
            else {
                dicCounts[name] = dicCounts[name] + 1;
                count++;
            }
            
        }

        /// <summary>
        /// Returns proportion of parameter name in all calls to AddName.
        /// </summary>
        /// <returns>Double in interval [0, 1]. Returns 0 if AddName has not been called.</returns>
        /// <param name="name">Name.</param>
        public double NameProportion(string name)
        {
            if (dicCounts.ContainsKey(name))
            {
                double frac;
                int temp = dicCounts[name];
                frac = (double)temp/count;
                return frac;
            }
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            NamesCount namesCount = new NamesCount();

            namesCount.AddName("James");
            namesCount.AddName("John");
            namesCount.AddName("Mary");
            namesCount.AddName("Mary");

            Console.WriteLine("Fraction of Johns: {0}", namesCount.NameProportion("John"));
            Console.WriteLine("Fraction of Marys: {0}", namesCount.NameProportion("Mary"));
            Console.WriteLine("Fraction of Maryys: {0}", namesCount.NameProportion("Maryy"));
            Console.ReadKey();
        }
    }
}