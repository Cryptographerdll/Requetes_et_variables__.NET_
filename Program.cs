using System;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Requêtes_et_variables__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> Personnes = new List<Personne>
            {
                new Personne("Jack","Lond",15,'M'),
                new Personne("Emma","Watson",23,'F'),
                new Personne("Windol","Hikar",41,'M'),
                new Personne("Lorem","bayn",30,'M'),
                new Personne("Daniel","Jmaes",25,'M'),
                new Personne("Erenna","Karen",18,'F'),
                new Personne("Donna","Dubov",32,'F'),
                new Personne("sam","kyte",59,'M'),
                new Personne("berlin","ile",20,'M'),
                new Personne("john","wick",74,'M'),
                new Personne("Julia","linda",60,'F'),
                new Personne("Jammy","white",27,'M'),
                new Personne("Moran","polm",38,'F')
            };

            // Créer une variable nom_complet

            var Query = from P
                        in Personnes
                        let nom_complet = P.Name + " " + P.Prenom
                        select new { nom_complet = nom_complet , Age = P.Age};

            foreach (var item in Query)
                WriteLine(item.nom_complet + " \t" + item.Age + " Years old");

            WriteLine("--------------------------------------------------------------------");

            // Créer une variable "initiale " qui contient seulement les initiales du nom et prenom : P.Name {0} + " " + P.Prenom {0} .

            var LongQuery = from P
                            in Personnes
                            let initiale = P.Name[0] + " . " + P.Prenom[0]
                            let taille_nom_complet = P.Name.Length + P.Prenom.Length
                            where P.Age >= 18 && P.Age <= 50
                            select new 
                            {
                                Nom = P.Name,
                                Prenom = P.Prenom,
                                Initiale = initiale,
                                Taille_nom_complet = taille_nom_complet,
                                Age = P.Age
                            };

            foreach (var item in LongQuery)
                WriteLine(item.Nom + " " + item.Prenom + " " + item.Initiale + " \t" + item.Taille_nom_complet + " \t" + item.Age);


        }
    }
}
