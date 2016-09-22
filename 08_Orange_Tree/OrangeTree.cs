using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Orange_Tree
{
    class OrangeTree
    {
        private int v1;
        private int v2;
        bool treealive = true; 
        public OrangeTree(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Age
        {
            get;
            internal set;
        }
        public int Height
        {
            get;
            internal set;
        }
        public int NumOranges { get; internal set; }
        public bool TreeAlive
        {
            get { return treealive; }
            set { treealive = value; }
        }
        public int OrangesEaten { get; internal set; }

        internal void OneYearPasses()
        {
            Age++;
            Height =  v2 +2;
            if (Age > 79) TreeAlive = false;
            if (Age > 1)
            {
                NumOranges = NumOranges +5;
            }
        }

        internal void EatOrange(int v)
        {
            if (NumOranges == 0)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
            OrangesEaten = OrangesEaten + v;
        }
        
    }
}
