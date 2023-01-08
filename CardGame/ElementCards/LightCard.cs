using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class LightCard : Cards, INonElementalCard
    {
        public LightCard(IRole role) : base(role) { }
        public float ClassIncrease { get; set; } = 1.2F;
    }
}
