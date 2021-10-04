using System;

namespace premier_programme
{
    class Program
    {

        static int DemanderAge(string personName) // ici on déclare des paramètres, que l'on sépare avec des virgules
        {
            int ageNum = 0;
            while (ageNum <= 0)
            {

                Console.Write(personName + ", et quel âge avez-vous ?");
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

        static string DemanderNom(int numeroPersonne)
        {
            string personName = "";
            while (personName == "")
            {
                Console.Write("Quel est le nom de la personne numéro" + numeroPersonne + " ? ");
                personName = Console.ReadLine();
                personName = personName.Trim(); // ceci est de la programmation orientée objet, le variable.Trim va supprimer les espaces, avant/après un mot, ou tous les espaces
                if (personName == "")
                    {
                    Console.WriteLine("Le nom ne doit pas être vide");
                    }
            }
            return personName;
        }

        static void AfficherInfosPersonne(string personName, int ageNum)
        {
            Console.WriteLine(); //on le laisse complètement vide pour sauter une ligne
            Console.WriteLine("Vous portez très bien vos " + ageNum + " et votre nom : " + personName + " également !");
            Console.WriteLine("et bientôt vous aurez " + (ageNum + 1) + " ans"); // Ici on refactorise, un +1 dans des parenthèses fait un calcul et non une concaténation

            // si l'age >=18 -> majeur sinon mineur
            // age == 17 -> Vous serez bientôt majeur
            // age == 18 -> vous êtes tout juste majeur

            // age >= 60 -> Vous êtes sénior
            // age < 10 -> Vous êtes un enfant

            // ET / OU (and && or ||)
            // age >= 12 ET age < 18 -> adolescent
            // age == 1 OU age == 2 -> bébé


            if (ageNum == 18) // Il est plus propre de commencer par les cas particuliers, comme les égalités
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (ageNum == 17) 
            {
                Console.WriteLine("Vous êtes bientôt majeur");
            }
            else if ((ageNum >= 12) && (ageNum < 18))
            {
                Console.WriteLine("Vous êtes un adolescent");
            }
            else if (ageNum >= 60)
            {
                Console.WriteLine("Vous êtes un sénior");
            }
            else if (ageNum > 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else if ((ageNum == 1) || (ageNum == 2))
            {
                Console.WriteLine("Vous êtes un bébé");
            }
            else if (ageNum < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }

        static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.UTF8; peut servir si les accents ne s'affichent pas par exemple

            // ON DEMANDE NOM ET ÂGE
            string personName1 = DemanderNom(1); // entre parenthèse on envoie des arguments, qui sont les valeurs que l'on passe
            string personName2 = DemanderNom(2);
            
            int ageNum1 = DemanderAge(personName1);
            int ageNum2 = DemanderAge(personName2);
            

            Console.WriteLine("Bonjour, enchanté " + personName1);

            AfficherInfosPersonne(personName1, ageNum1);
            AfficherInfosPersonne(personName2, ageNum2);


            // ici ageNum est forcément différent de 0
        }
    }
}
