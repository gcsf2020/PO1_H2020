using System;
namespace Mediatheque
{
    public class Fonctions
    {
        public static void Lancer() {
            Adherent monAdherent = new Adherent();
            Console.WriteLine(monAdherent.Nom);
            Console.WriteLine(monAdherent.Cotisation);
            Console.WriteLine(monAdherent.Id.ToString());
            Console.WriteLine(monAdherent.ToString());
            AfficherTous();
        }

        //Supprimer()
        public static void SupprimerAdherent() {
            int numeroIndexAdherents = Saisie.SaisirNombreEntier("Saisir un index");
            DonneesParDefaut.Adherents.RemoveAt(numeroIndexAdherents);
        }
        //AfficherTous()
        public static void AfficherTous()
        {
            foreach (var adherent in DonneesParDefaut.Adherents)
            {
                Console.WriteLine(adherent.ToString()); 
            }
        }

        public static void RerchercheParNom() {

        }
    }
}
