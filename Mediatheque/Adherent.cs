using System;
using System.Text;

namespace Mediatheque
{
    public class Adherent
    {
        //NombreAléatoire
        Random entienAléatoire = new Random();
        //Nom
        private string _nom;
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }
        //ID
        public int Id { get; set; }
        //Cotisation
        private double _cotisation = 10.00f;
        public double Cotisation { get { return _cotisation; } set { } }


        public Adherent(string nom)
        {
            Nom = nom;
            Id = 0;
        }

        public Adherent()
        {
            Nom = "anonyme";
            Id = entienAléatoire.Next(1, 999);
        }
        //ToString()
        public override string ToString()
        {
            StringBuilder chaineCaracteresAAfficher = new StringBuilder();
            chaineCaracteresAAfficher.AppendLine();
            chaineCaracteresAAfficher.Append("Nom: " + Nom);
            chaineCaracteresAAfficher.Append("\t");
            chaineCaracteresAAfficher.Append("Id: " + Id);
            chaineCaracteresAAfficher.Append("\t");
            chaineCaracteresAAfficher.Append("Cotisation: " + Cotisation);
            return chaineCaracteresAAfficher.ToString();
        }
        //ModifierCotisation(double Cotisation)
        public void ModifierCotisation(double p_cotisation)
        {
            Cotisation = p_cotisation;
        }

        //SaisirAdherent()
        public static void SaisirAdherent()
        {

            Adherent monAdherent = new Adherent();
            monAdherent.Nom = SaisirNom();
        }

        public static string SaisirNom()
        {
            string nom;
            do
            {
                nom = Saisie.SaisirChaineCaracteres("le nom de l'adhérent");
            } while (string.IsNullOrEmpty(nom));
            return nom;
        }
        public static int SaisirId() {
            int id;
            do
            {
                id = Saisie.SaisirNombreEntier("l'Id");
            } while (id > 0 && id < 1000);
            return id;
        }
        //ModiferNomAdhérent()
        public void ModifierAdherent()
        {
            Nom = SaisirNom();
        }

        //Afficher()
        public static void AfficherAdherent(Adherent p_adherent)
        {
            if (p_adherent == null)
            {
                throw new ArgumentNullException("Le paremêtre est null", "p_adherent");
            }
            Console.WriteLine(p_adherent);
        }
    }
}
