using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListØvelse1
{
    public class Die
    {
        private static Random r = new Random();
        private int eyes = 0;
        public void Roll()
        {
            eyes = r.Next(1, 7);
        }
        public int GetEyes()
        {
            return eyes;
        }
    }
}
