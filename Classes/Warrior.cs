using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PR.Classes
{
    public class Warrior
    {
        public double HP { get; set; }

        public Warrior(double HP)
        {
            this.HP = HP;
        }

        public virtual void ShootDamage(double Damage)
        {
            this.HP -= Damage;
        }
    }
}
