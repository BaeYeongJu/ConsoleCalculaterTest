using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class MemoryManager
    {
        public MemoryManager() { }

        public double Save(double firstMemory, double lastMemory)
        {
            firstMemory += lastMemory;
            return firstMemory;
        }

        public double Load(double result)
        {
            return result;
        }

        public double Clear()
        {
            return 0;
        }

        public double Add(double number, int count)
        {
            return number * count;
        }

        public double Sub(double number, int count)
        {
            return number / count;
        }
    }
}
