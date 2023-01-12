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
        /// <summary>
        /// The card which can perfom attacks
        /// only 1 card can be active at a time per player
        /// </summary>
        public Cards ActiveCard {
            get { return _activeCard; }
            set { if(Cards.Contains(value))
                    _activeCard = value;
            }
        }
    }
}
