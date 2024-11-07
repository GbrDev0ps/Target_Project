using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Target_Project.Models
{
    public class Fibonacci
    {
        public static bool PertenceFibonacci(int num)
        {
            int a = 0;
            int b = 1;

            if (num == 0 || num ==1) return true;

            int proximo = a + b;

            while (proximo <= num)
            {
                if (proximo == num) return true;
                a = b;
                b = proximo;
                proximo = a + b;
            }

            return false;
        }



    }
}