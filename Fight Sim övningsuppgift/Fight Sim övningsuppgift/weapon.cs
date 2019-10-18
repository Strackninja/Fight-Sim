using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Sim_övningsuppgift
{
    class weapon
    {


        protected int mindamage = 5;
        protected int maxddamage = 10;
        static Random generator = new Random();
        public virtual int Attack()
        {
            return generator.Next(mindamage, maxddamage);
        }

    }
}
