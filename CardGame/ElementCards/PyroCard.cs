using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class PyroCard : Cards
    {
        public PyroCard(IRole role) : base(role) { }
        /// <summary>
        /// Applies Burning effect to enemy and deals 200 bonus damage
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            E.AppliedEffects.Add(StatusEffect.Burning);
            AttackEnemy(E, 200);
        }
    }
}
