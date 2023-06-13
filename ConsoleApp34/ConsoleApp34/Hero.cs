using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Hero
    {
            public Hero(int health, int damage, int level, int experience)
            {
                Health = health;
                Damage = damage;
                Level = level;
                Experience = experience;
            }

            public int Health { get; set; }
            public int Damage { get; set; }
            public int Level { get; set; }
            public int Experience { get; set; }
        }
}
