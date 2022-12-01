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

        public double SaveMemory(double firstMemory, double lastMemory)
        {
            firstMemory += lastMemory;
            return firstMemory;
        }

        public double LoadMemory(double result)
        {
            return result;
        }

        public double ClearMemory()
        {
            return 0;
        }

        public double AddMemory(double number, int count)
        {
            return number * count;
        }

        public double SubMemory(double number, int count)
        {
            return number / count;
        }
    }
}
