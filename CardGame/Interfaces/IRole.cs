using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IRole
    {
        //Adjusts properties for respective role
        void SetRolleStats(Cards C);
        /// <summary>
        /// Executes Specific role ability
        /// </summary>
        /// <param name="C">Player card</param>
        /// <param name="E">Enemy card</param>
        void SpecialAbility(Cards C, Cards E);
    }
}
