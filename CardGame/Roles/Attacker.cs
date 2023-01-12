using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Roles
{
    public class Attacker : IRole
    {
        /// <summary>
        /// Increases attack and reduces health
        /// </summary>
        /// <param name="C"></param>
        public void SetRolleStats(Cards C)
        {
            C.Health -= 100;
            C.Attack += 100;
        }
        /// <summary>
        /// Performs 2 attacks in one turn
        /// </summary>
        /// <param name="C"></param>
        /// <param name="E"></param>
        public void SpecialAbility(Cards C, Cards E)
        {
            C.AttackEnemy(E);
            C.ElementalAttack(E);
        }
    }
}
