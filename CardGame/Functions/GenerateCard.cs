using CardGame.ElementCards;
using CardGame.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Functions
{
    public static class GenerateCard
    {
        public static Cards CreateCard(char element, char role)
        {
            IRole cardRole = CreateRole(role);
            return CreateElement(element, cardRole);
        }
        private static Cards CreateElement(char element, IRole role) {
            switch (element)
            {
                case '1':
                    return new PyroCard(role);
                case '2':
                    return new HydroCard(role);
                case '3':
                    return new AnemoCard(role);
                case '4':
                    return new GeoCard(role);
                case '5':
                    return new LightCard(role);
                case '6':
                    return new DarknessCard(role);
                default: 
                    throw new ArgumentException("This Element doesn't exist");
            }
        }
        private static IRole CreateRole(char role)
        {
            switch (role)
            {
                case '1':
                    return new Attacker();
                case '2':
                    return new Healer();
                case '3':
                    return new Support();
                case '4':
                    return new Tank();
                default:
                    throw new ArgumentException("This role doesn't exist");
            }
        }
    }
}
