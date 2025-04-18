using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class Animal
    {
        public string Name;
        public string Species;
        public int Age;
        public double Weight;
        public double Height;
        public string Region;
        public bool IsWild;
        public bool IsDied;

        public double indexMassBody
        {
            get
            {
                return GetIndexMassBody();
            }
        }

        public double GetIndexMassBody() // Індекс маси тіла
        {
            return Weight / (Height * Height);
        }
    }
}