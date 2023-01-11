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
        /// <summary>
        /// Constructor that sets every property to default value
        /// Sets id of card to unique value
        /// </summary>
        /// <param name="role">The role to be assigned to the card</param>
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
        // Multiplies damage dealt to opponent
        public static float DamageMult { get; set; }
        // Reduces damage taken by opponent
        public static float DefenseMult { get; set; }
        // Health of the card
        private int health;
        // How much damage is dealt by default
        private int attack;
        // If health reaches 0 or below, destroys the card
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
        // Increases id by 1 for every new card created
        public static int IdIncrease { get; set; }
        // Id of Card
        public int ID { get; set; }
        // Assigns unique abilities to the card
        public IRole Role { get; set; }
        // Decides if the card has an damage advantage to the opponent
        public enum ElementalAdvantage
        {
            Advantage,
            Neutral,
            Disadvantage
        }
        // Effects that can be applied to card
        public enum StatusEffect
        {
            Cut,
            Burning,
            Shielded,
            Wet,
            Blinded,
            Weakened

        }
        // Effects applied to card for specific duration
        public List<StatusEffect> AppliedEffects { get; set; }
        /// <summary>
        /// Writes the current state of the card
        /// </summary>
        public void ShowOutput()
        {
            Console.WriteLine("ID is {0} and Health and Attack is: {1} {2}",
                            this.ID,
                            this.Health,
                            this.Attack);
        }
        /// <summary>
        /// Takes the attack property and increases it based on multipliers
        /// </summary>
        /// <returns> Final attack value</returns>
        public int attackValue() {
            int attackValue = Convert.ToInt32(Attack * DamageMult);
            return attackValue;
        }
        /// <summary>
        /// Atacks the opponent
        /// </summary>
        /// <param name="E"> The opponent card</param>
        public void attackEnemy(Cards E)
        {
            ElementalAdvantage elementalAdvantage = new ElementalAdvantage();
            elementalAdvantage = ElementalAdvantage.Neutral;
            E.receiveDamage(attackValue(),elementalAdvantage);
        }
        /// <summary>
        /// Take damage based on attack value of opponent and elemental advantage
        /// </summary>
        /// <param name="Damage">Attack value to be taken from health</param>
        /// <param name="Element"> Elemental advantage</param>
        public void receiveDamage(float Damage, ElementalAdvantage Element)
        {
            switch(Element)
            {
                case ElementalAdvantage.Advantage:
                    Damage = Damage * (float)1.5;
                    break;
                case ElementalAdvantage.Disadvantage:
                    Damage = Damage * (float)0.75;
                    break;
                default:
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
