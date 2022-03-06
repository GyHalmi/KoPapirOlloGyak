using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOlloGyak
{
    public abstract class Strategy
    {
        public int LastHit;
        public static Random rnd = new Random();
        public abstract int NewHit();
        protected int RandomHit()
        {
            return rnd.Next(1, 4);
        }

    }

    public class StratRandom : Strategy
    {
        public override int NewHit()
        {
            return RandomHit();
        }
    }
    public class StratAll : Strategy
    {
        int[] last3 = new int[3];
        public void ClearLast3()
        {
            last3 = new int[]{ -1,-1,-1};
        }
        public override int NewHit()
        {
            int noHit = -1;
            if (!last3.Contains(noHit) )
            {
                ClearLast3();
            }

            int indLastEmpty = 0;
            while(indLastEmpty<last3.Length && indLastEmpty == noHit)
            {
                indLastEmpty++;
            }

            int newHit = -1;
            bool again = true;
            while (again)
            {
                newHit = RandomHit();
                int i = 0;
                while (i < indLastEmpty && last3[i] != newHit) {
                    i++;
                }
                if (i >= indLastEmpty)
                {
                    again = false;
                    last3[indLastEmpty] = newHit;
                }
            }

            return newHit;
        }
        
    }
    public class StratBeatLast : Strategy
    {
        public override int NewHit()
        {
            throw new NotImplementedException();
        }
    }
}
