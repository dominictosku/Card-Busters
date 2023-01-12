using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Roles
{
    public class Tank : IRole
    {
        /// <summary>
        /// Increase defense massively, decreases attack
        /// </summary>
        /// <param name="C"></param>
        public void SetRolleStats(Cards C)
        {
            C.DefenseMult += 1.5F;
            C.Attack = 50;

        }
        /// <summary>
        /// Further increases defense
        /// Adds shield to card
        /// </summary>
        /// <param name="C"></param>
        /// <param name="E"></param>
        public void SpecialAbility(Cards C, Cards E)
        {
            C.DefenseMult += 1.0F;
            C.AppliedEffects.Add(Cards.StatusEffect.Shielded);
        }
    }
}
