using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Cards> Cards { get; set; }
        private Cards _activeCard;
        public Cards ActiveCard {
            get { return _activeCard; }
            set { if(Cards.Contains(value))
                    _activeCard = value;
            }
        }
    }
}
