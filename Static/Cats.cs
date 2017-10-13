using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Cats
    {
        private int catCount;

        public int CatCount
        {
            get { return this.catCount; }
            set { this.catCount = value; }
        }

        public Cats()
        {
            //default
        }

        public void WarCry()
        {
            Console.WriteLine("We are an army of " + catCount + " cats!!");
        }
    }
}
