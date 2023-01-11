using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Functions
{
    public static class StatIncrease
    {
        /// <summary>
        /// Increases attack and health for light and darkness cards
        /// </summary>
        /// <param name="C"></param>
        public static void NonElementalBonus(INonElementalCard C)
        {
            double tempAttack = Math.Round(C.Attack * C.ClassIncrease);
            double tempHealth = Math.Round(C.Health * C.ClassIncrease);
            C.Attack = Convert.ToInt32(tempAttack);
            C.Health = Convert.ToInt32(tempHealth);
        }
    }
}
