using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        public FactorialService()
        {
            
        }

        public int GetFactorial(int input)
        {
            int result = input;
            for (int i = input - 1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
