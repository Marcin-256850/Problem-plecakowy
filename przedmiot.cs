using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nina_Marcin
{
    public class item
    {
        public int id { get; set; }
        public int waga { get; set; }
        public int value { get; set; }

        public void wyswietl()
        {
            Console.WriteLine(id,waga,value);
        }
    }
}
