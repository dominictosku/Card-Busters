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
        // Boosts attack and health
        public float ClassIncrease { get; set; } = 1.2F;
        // Can block an attack once
        public bool BlockAttack { get; set; }
    }
}
