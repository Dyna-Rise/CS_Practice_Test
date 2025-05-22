using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_object_test
{
    internal class Warrior : Player
    {
        public Warrior(string name) : base(name)
        {
            hp = 120;
            attack = 120;
            job = "戦士";
        }

        public void HardAttack()
        {
            Console.WriteLine(Name + "の両手持ち攻撃！");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("ハイパース―バーソード！");
        }
    }
}
