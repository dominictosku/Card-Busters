using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Roles
{
    public class Healer : IRole
    {
        /// <summary>
        /// Increase Health, but reduces attack
        /// </summary>
        /// <param name="C"></param>
        public void SetRolleStats(Cards C)
        {
            C.Health += 500;
            C.Attack-= 40;
        }
        /// <summary>
        /// Restores Health for a card and reduces defense of enemy
        /// </summary>
        /// <param name="C"></param>
        /// <param name="E"></param>
        public void SpecialAbility(Cards C, Cards E)
        {
            C.Health += 300;
            E.DefenseMult -= 0.25F;
        }
    }
}
