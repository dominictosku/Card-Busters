using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Interfaces
{
    public interface INonElementalCard
    {
        int Health { get; set; }
        int Attack { get; set; }
        float ClassIncrease { get; set; }
    }
}
