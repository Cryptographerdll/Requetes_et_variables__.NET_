using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requêtes_et_variables__.NET_
{
    class Personne
    {
        private string name;
        private string prenom;
        private int age;
        private char sexe;
        private bool est_Ingénieur;

        public Personne(string name, string prenom, bool ingénieur)
        {
            this.name = name;
            this.prenom = prenom;
            this.est_Ingénieur = ingénieur;
        }

        public Personne(string name, string prenom, int age, char sexe)
        {
            this.name = name;
            this.prenom = prenom;
            this.age = age;
            this.sexe = sexe;
        }

        public Personne(string name, string prenom, int age, char sexe, bool est_Ingénieur) 
            : this(name, prenom, age, sexe)
        {
            this.est_Ingénieur = est_Ingénieur;
            Name = name;
            Prenom = prenom;
            Age = age;
            Sexe = sexe;
            Est_Ingénieur = est_Ingénieur;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public char Sexe
        {
            get
            {
                return this.sexe;
            }

            set
            {
                this.sexe = value;
            }
        }

        public bool Est_Ingénieur
        {
            get
            {
                return this.est_Ingénieur;
            }

            set
            {
                this.est_Ingénieur = value;
            }
        }
    }
}
