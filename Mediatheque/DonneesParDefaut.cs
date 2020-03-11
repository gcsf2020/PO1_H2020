using System;
using System.Text;
using System.Collections.Generic;

namespace Mediatheque
{
    public class DonneesParDefaut
    {
        public static List<Adherent> Adherents = new List<Adherent> {
            new Adherent { Nom = "Alain" },
            new Adherent { Nom = "Bob" },
            new Adherent { Nom = "Charle" },
            new Adherent { Nom = "Fraisinette"}
        };

        public DonneesParDefaut()
        {
        }
    }
}
