using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Sim_övningsuppgift
{
    class fighter
    {

        private int hp;
        string name;
        static Random generator = new Random();
        public int attack()
        {

            return generator.Next(0, 101);

        }

        public void Hurt(int amount)
        {

            hp = hp - amount;
            if (hp < 1)
            {
                hp = 0;
            }
            
        }

        public bool IsAlive()
        {

            if(hp < 1)
            {
                return false;
            }

            return true;

        }

        int GetHp()
        {

            return hp;

        }
    }
}
