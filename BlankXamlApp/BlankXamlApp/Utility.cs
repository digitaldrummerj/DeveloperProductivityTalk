using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankXamlApp
{
    public class Utility
    {
        private static Random rnd = new Random();

        static public bool LongOperation()
        {
            int n = Utility.rnd.Next(1, 1000000);

            try
            {
                if (n > 950000)
                {
                    throw new ArgumentException("n is too large.");
                }

                if (Enumerable.Range(1, n).Where(x => n % x == 0).Count() == 2)
                { return true; }

                else return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception with operation, {ex.Message}");
                return false;
            }
        }
    }
}
