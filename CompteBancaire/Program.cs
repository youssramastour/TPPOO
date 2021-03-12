using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Clt1 = new Client("tazi","ali","ali@hotmail.com");
            Client Clt2 = new Client("sadik", "salma", "sal@htmail.com");
            Client Clt3 = new Client("farabi", "malak", "farabi@htmail.com");
            Client Clt4 = new Client("sadik", "hafsa", "hafsa.sad@htmail.com");
            Clt1.afficher();
            Compt compte1 = new Compt();
            Compt compte2 = new Compt();
            Compt compte3 = new Compt();
            Compt compte4 = new Compt();
            compte1.consulter();
            compte1.crediter(300);
            Clt4.afficher();
        }
    }
}
