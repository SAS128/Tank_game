using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.Logic
{
    abstract class Bonus
    {
        protected int Value;
        public abstract object GiveEffect(object sender);
    }
}
