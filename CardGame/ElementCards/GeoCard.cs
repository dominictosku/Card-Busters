using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class GeoCard : Cards
    {
        public GeoCard(IRole role) : base(role) { }
        /// <summary>
        /// Applies shield to self and removes shield from enemy
        /// deals 100 bonus damage
        /// </summary>
        /// <param name="E"></param>
        public override void ElementalAttack(Cards E)
        {
            //Gives self shielded effect and removes from enemy
            AppliedEffects.Add(StatusEffect.Shielded);
            if(E.AppliedEffects.Contains(StatusEffect.Shielded))
                E.AppliedEffects.Remove(StatusEffect.Shielded);
            AttackEnemy(E, 100);
        }
    }
}
