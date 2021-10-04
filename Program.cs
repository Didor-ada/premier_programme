using System;

namespace premier_programme
{
    class Program
    {

        static int DemanderAge()
        {
            int ageNum = 0;
            while (ageNum <= 0)
            {

                Console.Write("Et quel âge avez-vous ?");
                string personAge = Console.ReadLine();

                try
                {
                    ageNum = int.Parse(personAge);

                    if (ageNum < 0)
                    {
                        Console.WriteLine("Erreur : l'âge ne doit pas être négatif");
                    }

                    if (ageNum == 0)
                    {
                        Console.WriteLine("Erreur : l'âge ne doit pas être égal à 0");
                    }

                }
                catch
                {
                    Console.WriteLine("Vous ne pouvez rentrer que des chiffres quand je vous demande votre âge");
                }
            }
            return ageNum;
        }

        static string DemanderNom()
        {
                        // ON DEMANDE LE NOM
            string personName = "";
            while (personName == "")
            {
                Console.Write("Quel est votre nom ?");
                personName = Console.ReadLine();
                personName = personName.Trim(); // ceci est de la programmation orientée objet, le variable.Trim va supprimer les espaces, avant/après un mot, ou tous les espaces
                if (personName == "")
                    {
                    Console.WriteLine("Le nom ne doit pas être vide");
                    }
            }
            return personName;
        }

        static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.UTF8; peut servir si les accents ne s'affichent pas par exemple

            // ON DEMANDE L'ÂGE
            int ageNum = DemanderAge();
            string personName = DemanderNom();

            Console.WriteLine("Bonjour, enchanté " + personName);

            // ici ageNum est forcément différent de 0

            // ON AFFICHE LES RESULTATS
            Console.WriteLine("Vous portez très bien vos " + ageNum);

            int ageProchain = ageNum + 1;
            Console.WriteLine(" et bientôt vous aurez " + ageProchain + " ans");
        }
    }
}
