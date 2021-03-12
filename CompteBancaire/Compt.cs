using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Compt
    {
        private readonly int NumComp;
        private static int cpt = 0;
        private MAD solde;
        private readonly Client titulaire;
        private readonly static MAD plafond = new MAD();
        public Compt() { }
        public Compt( MAD sol, Client titul, MAD PLA)
        {
            this.NumComp = cpt++;
            this.solde = sol;
            this.titulaire = titul;
            
        }
        public Compt( MAD sol,Client titul)
        {
            this.NumComp = cpt++;
            this.solde = sol;
        }
        public bool crediter(MAD sol)
        {
            this.solde += sol;
            Console.Out.WriteLine("Opération bien effectuée");
            return true;

        }

        internal void crediter(int v)
        {
            throw new NotImplementedException();
        }

        public bool deviter(MAD somme)
        {
            this.solde -= somme;
            Console.Out.WriteLine("Opération bien effectuée");
            return true;
        }
        public bool deviPlafond(MAD somme)
        {
            if ((this.solde - solde) >plafond)
            {
                this.solde -= solde;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verser(Compt c, MAD somme) ///discuter 
        {
            if (c.solde > somme )
            {
                c.solde -= somme;
                solde += somme;
                Console.Out.WriteLine("Opération bien effectuée");
                return true;
            }
            else
                Console.Out.WriteLine("Solde de compte insuffisant");
            return false;
        }
        public void saisir()
        {
            Console.WriteLine("entre votre solde");
            Console.ReadLine();
             
        }
        public bool consulter()
        {
            int numCompt;
            Console.WriteLine("entrer le numero de compte que vous voulez consulter?");
            numCompt =int.Parse(Console.ReadLine());
            Console.WriteLine("le titulaire" + titulaire + "son solde" + solde + "son plafond" + plafond);
            return true;

        }
    }
}
