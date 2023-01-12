using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class LightCard : Cards, INonElementalCard
    {
        public LightCard(IRole role) : base(role) { }
        /// <summary>
        /// Applies blinded to enemy
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            E.AppliedEffects.Add(StatusEffect.Blinded);
            AttackEnemy(E, 0);
        }
        // Boosts attack and health
        public float ClassIncrease { get; set; } = 1.2F;
        // Can block an attack once
        public bool BlockAttack { get; set; }
    }
}
