using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class MAD
    {
        private double valeur;
        private MAD PLAFOND;
        private int v;

        public MAD(double v,MAD plafond)
        {
            this.valeur = v;
            this.PLAFOND = plafond;
        }
        public MAD()
        {}
        public MAD(int v)
        {
            this.v = v;
        }
        public static MAD operator +(MAD somme, MAD solde)
        {
            MAD p = new MAD(0);
            p.valeur = solde.valeur + somme.valeur;
            return p;
        }
        public static bool operator>(MAD somme,MAD solde)
        {
            if (somme.valeur > solde.valeur)
                return true;
            else
                return false;

        }
        public static bool operator<(MAD somme,MAD solde)
        {
            if (somme.valeur < solde.valeur)
                return true;
            else
                return false;
        }
        public static MAD operator-(MAD somme, MAD solde)
        {
            MAD m = new MAD(0);
            m.valeur = solde.valeur - somme.valeur;
            return m;
        }
        public void afficher()
        {
            Console.WriteLine("Votre valeur en MAD" + valeur);
            Console.ReadLine();
        }
    }
}
