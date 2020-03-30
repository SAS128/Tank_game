using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting.TankGame.Logic
{
    abstract class Bonus
    {
        int effectAmount;
        public abstract object GiveEffect(object sender);
    }
}
