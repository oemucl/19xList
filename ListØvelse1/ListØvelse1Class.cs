using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListØvelse1
{
    class ListØvelse1Class
    {
        public void UdførØvelse(int dieCount)
        {
            List<Die> ls = new List<Die>();
            Die d ;

            for (int i = 0; i < dieCount; i++)
            {
                d = new Die();
                ls.Add(d);
            }

            for (int i = 0; i < ls.Count; i++)
            {
                ls[i].Roll();
                Console.WriteLine(ls[i].GetEyes());
            }

            Console.WriteLine();
            foreach (Die die in ls)
            {
                die.Roll();
                Console.WriteLine(die.GetEyes());
            }
        }
    }
}
