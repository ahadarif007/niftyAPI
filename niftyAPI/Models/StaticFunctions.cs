using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace niftyAPI.Models
{
    public class StaticFunctions
    {

        public static int square(int n)
        {
            return n * n;
        }

        public static Double squareRoot(int n)
        {
            return Math.Sqrt(n);
        }

        public static int factorial(int n)
        {
            if (n == 1) return 1;
            else return n * factorial(n-1);
        }

        public static int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        public static bool HistoryInput(string operation, int value)
        {
            using(var db= new AppDbContext())
            {
                // Create
                db.History.Add(new History { operationString = operation, value = value });
                db.SaveChanges();
                return true;
            }

        }



    }
}
