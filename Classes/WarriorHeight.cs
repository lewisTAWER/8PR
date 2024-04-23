using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PR.Classes
{
    public class WarriorHeight : Warrior
    {
        public WarriorHeight(double HP) : base(HP)
        {
        }

        public override void ShootDamage(double Damage)
        {
            this.HP -= Damage * 0.5;
        }
    }
}
