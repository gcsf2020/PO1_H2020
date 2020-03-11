using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Saisie
    {
        public static int SaisirNombreEntier(string p_nomVarialbleASaisir)
        {
            Console.Write("Saisir {0} : ", p_nomVarialbleASaisir);
            int nombreEntierSaisi = int.Parse(Console.ReadLine());

            return nombreEntierSaisi;
        }

        public static string SaisirChaineCaracteres(string p_nomVarialbleASaisir)
        {
            Console.Write("Saisir {0} : ", p_nomVarialbleASaisir);
            string chaineCaracteresSaisie = Console.In.ReadLine();

            return chaineCaracteresSaisie;
        }
    }
}
