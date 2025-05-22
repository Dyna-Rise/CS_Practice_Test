using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_object_test
{
    internal class Player
    {
        private string name;
        protected int hp;
        protected float attack;
        protected float defense;
        protected float speed;
        protected string job;

        public string Name
        {
            get { return name; }
        }

        public int HP
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }

        public Player() : this("名無し")
        {
            //this.name = "名無し";
            //this.hp = 100;
            //this.attack = 100;
            //this.defense = 100;
            //this.speed = 100;
            //this.job = "平民";
        }

        public Player(string name)
        {
            this.name = name;
            this.hp = 100;
            this.attack = 100;
            this.defense = 100;
            this.speed = 100;
            this.job = "平民";
        }

        public void ShowStatus()
        {
            Console.WriteLine(name + "(" + job + ")のステータス");
            Console.WriteLine("HP：" + hp);
            Console.WriteLine("Attack：" + attack);
            Console.WriteLine("Defense：" + defense);
            Console.WriteLine("Speed：" + speed);
        }

        public void NameSet(string name)
        {
            this.name = name;
        }
        public void HpSet(int hp)
        {
            this.hp = hp;
        }

        public void AttackSet(float attack)
        {
            this.attack = attack;
        }

        public void AttackUp()
        {
            attack += 10;
        }

        public void AttackUp(int value)
        {
            attack += value;
        }

        public void DefenseSet(float defense)
        {
            this.defense = defense;
        }

        public void DefenseUp()
        {
            defense += 10;
        }

        public void DefenseUp(int value)
        {
            defense += value;
        }

        public void SpeedSet(float speed)
        {
            this.speed = speed;
        }


        public void SpeedUp()
        {
            speed += 10;
        }

        public void SpeedUp(int value)
        {
            speed += value;
        }

        public virtual void SpecialAttack()
        {
            Console.WriteLine("なんかすごい特技が発動した！");
        }

    }
}
