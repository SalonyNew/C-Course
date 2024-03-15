using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssignment
{
    public class Character
    {
        public string name;
        public int health;
        public int attack;
        public int defence;

        public void Attack(Character target)
        {
            int damage = Math.Max(0, attack - target.defence);
            target.health -= damage;

            if(damage>0)
            {
                Console.WriteLine($"{damage}");
            }
            else
            {
                Console.WriteLine("No effect on target");
            }


        }
        public virtual void Defence()
        {
            Console.WriteLine($"{name} is defending");
        }
    }

    public class Warrior: Character
    {
        public void Charge(Character target)
        {
            Console.WriteLine($"{name} charges at {target.name}.");
        }

        public override void Defence()
        {
            base.defence += 5;
            Console.WriteLine($"{name} is defencing and gain +5 defence points");
        }
    }
    public class Program
    {
        static void Main()
        {
        }
    }
}
