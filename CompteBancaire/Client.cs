using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        public Client( string a,string b,string c)
        {
            this.nom = a;
            this.prenom = b;
            this.adresse = c;
        }
        public void afficher()
        {
            Console.WriteLine("votre non:" + nom);
            Console.ReadLine();
            Console.WriteLine("votre prenom:" + prenom);
            Console.ReadLine();
            Console.WriteLine("votre adresse:" + adresse);
            Console.ReadLine();
        }
    }
}
