using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ElementCards
{
    public class DarknessCard : Cards, INonElementalCard
    {
        public DarknessCard(IRole role) : base(role) { }
        public float ClassIncrease { get; set; } = 1.6F;
    }
}
