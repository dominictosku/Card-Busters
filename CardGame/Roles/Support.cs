using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Roles
{
    public class Support : IRole
    {
        /// <summary>
        /// Increase Defense and Damage of the card
        /// </summary>
        /// <param name="C"></param>
        public void SetRolleStats(Cards C)
        {
            C.DefenseMult += 0.5F;
            C.DamageMult += 1.0F;
        }
        /// <summary>
        /// Doubles damage output
        /// Adds to status effects to Enemy
        /// Todo! This is completly broken
        /// </summary>
        /// <param name="C"></param>
        /// <param name="E"></param>
        public void SpecialAbility(Cards C, Cards E)
        {
            C.DamageMult *= 2;
            E.AppliedEffects.Add(Cards.StatusEffect.Weakened);
            E.AppliedEffects.Add(Cards.StatusEffect.Blinded);
        }
    }
}
