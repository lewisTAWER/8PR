using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PR.Classes
{
    public class WarriorLite : Warrior
    {
        public WarriorLite(double HP) : base(HP)
        {
        }

        public override void ShootDamage(double Damage)
        {
            this.HP -= Damage * 0.7;
        }
    }
}
