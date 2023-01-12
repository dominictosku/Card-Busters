using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class DarknessCard : Cards, INonElementalCard
    {
        public DarknessCard(IRole role) : base(role) { }
        public float ClassIncrease { get; set; } = 1.6F;
        /// <summary>
        /// Applies weakened to enemy and deals 100 bonus damage
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            E.AppliedEffects.Add(StatusEffect.Weakened);
            AttackEnemy(E, 100);
        }
    }
}
