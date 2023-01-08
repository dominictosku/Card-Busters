using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Functions
{
    public static class CreateDeck
    {
        public static List<Cards> GenerateRandomDeck(byte times)
        {
            List<Cards> cards = new List<Cards> { };
            Random rd = new Random();
            char[] element = new char[] { '1', '2', '3', '4', '5', '6' };
            char[] role = new char[] { '1', '2', '3', '4' };
            for (byte i = 0; i < times; i++)
            {
                byte rand_element = Convert.ToByte(rd.Next(0, element.Length));
                byte rand_role = Convert.ToByte(rd.Next(0, role.Length));
                cards.Add(GenerateCard.CreateCard(element[rand_element], role[rand_role]));
            }
            return cards;
        }
    }
}
