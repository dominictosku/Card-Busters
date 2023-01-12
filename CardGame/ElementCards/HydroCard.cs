using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class HydroCard : Cards
    {
        public HydroCard(IRole role) : base(role) { }
        /// <summary>
        /// Applies wet to enemy and deals 2 bonus damage
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            E.AppliedEffects.Add(StatusEffect.Wet);
            AttackEnemy(E, 2);
        }
    }
}
