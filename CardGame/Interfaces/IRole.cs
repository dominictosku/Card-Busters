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
        //Acitvaes role exclusive ability
        void SpecialAbility(Cards C, Cards E);
    }
}
