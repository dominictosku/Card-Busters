using CardGame.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Cards
    {
        public Cards(IRole role)
        {
            DamageMult = 1.0F;
            DefenseMult = 1.0F;
            Health = 1000;
            Attack = 100;
            ID = IdIncrease;
            IdIncrease += 1;
            Role = role;
        }
        public static float DamageMult { get; set; }
        public static float DefenseMult { get; set; }
        private int health;
        private int attack;
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    DestroyCard();
                    return;
                }
                health = value;
            }
        }
        public int Attack { get { return attack; } set { attack = value; } }
        public static int IdIncrease { get; set; }

        public int ID { get; set; }
        public IRole Role { get; set; }
        public enum ElementalAdvantage
        {
            Advantage,
            Neutral,
            Disadvantage
        }
        public void ShowOutput()
        {
            Console.WriteLine("ID is {0} and Health and Attack is: {1} {2}",
                            this.ID,
                            this.Health,
                            this.Attack);
        }
        public int attackValue() {
            int attackValue = Attack;
            return attackValue;
        }
        public void attackEnemy(Cards E)
        {
            E.Health -= attackValue();
        }
        public void receiveDamage(float Damage, ElementalAdvantage Element)
        {
            switch(Element)
            {
                case ElementalAdvantage.Advantage:
                    Damage = Damage * (float)1.5;
                    break;
            }
            int receivedDamage = Convert.ToInt32(Damage / DefenseMult);
            Health -= receivedDamage;
        }
        public void DestroyCard()
        {
            Console.WriteLine("Card Destroyed");
        }
    }
}
