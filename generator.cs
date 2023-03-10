using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Nina_Marcin
{
    internal class generator
    {
        Random random = new Random();
        public int rand(int low, int up)
        {
            return random.Next(low, up);
        }
        public override string ToString()
        {
            int x = 1;
            string str = "tekst" + x.ToString() + "tekst";
            return "to jest nasz generator";
        }
    }
}
