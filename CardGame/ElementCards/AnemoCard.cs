using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class AnemoCard : Cards
    {
        public AnemoCard(IRole role) : base(role) {}
        /// <summary>
        /// Applies cut to enemy and deals 20 bonus damage
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            E.AppliedEffects.Add(StatusEffect.Cut);
            AttackEnemy(E, 20);
        }
    }
}
