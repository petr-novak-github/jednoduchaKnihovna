using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jednoduchyPrikladNaList
{
    class Book
    {
        private string nazevKnihy;
        private int pocetStranKnihy;
        private Autor autor;

        public Book()
        {

        }
        public Book(string nazevKnihy, int pocetStranKnihy, Autor autor)
        {
            this.nazevKnihy = nazevKnihy;
            this.pocetStranKnihy = pocetStranKnihy;
            this.autor = autor;
        }

        public override string ToString() {
            return $"Kniha: {nazevKnihy} , pocet stran: {pocetStranKnihy},  autor: {autor} \n";
        }

    }

    class Autor
    {
        private string jmeno;
        private int rocnikNarozeni;
        public Autor()
        {

        }
        public Autor(string jmeno, int rocnikNarozeni)
        {
            this.jmeno = jmeno;
            this.rocnikNarozeni = rocnikNarozeni;
        }

        public override string ToString()
        {
            return $" {jmeno}, rocnik narozeni autora: {rocnikNarozeni}"; 
        }

    }

    class Knihovna
    {
        private string adresa;
        private List<Book> knihyVknihovne;

        public Knihovna(string adresa, List<Book> knihyVknihovne)
        {
            this.adresa = adresa;
            this.knihyVknihovne = knihyVknihovne;
        }

        public void PridejKnizkuDoKnihovny(Book kniha) {
            knihyVknihovne.Add(kniha);
        
        }

        public override string ToString()
        {
            string ret="Vypis knihovny: \n";
            foreach (Book item in knihyVknihovne)
            {
                ret += item.ToString();
            }


            return ret;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Autor autor1 = new Autor("Juraj Bednar", 1980);
            Autor autor2 = new Autor("Dominik Stroucal", 1988);
            
            Book kniha1 = new Book("Hackni sa",500,autor1);
            Book kniha2 = new Book("Bitcoin a jine penize",200,autor2);

            List<Book> knizkyVknihovne11 = new List<Book>();

            Knihovna knihovna1 = new Knihovna("Pribor", knizkyVknihovne11 );

            knihovna1.PridejKnizkuDoKnihovny(kniha1);
            knihovna1.PridejKnizkuDoKnihovny(kniha2);

            Console.WriteLine(knihovna1.ToString());

            Console.ReadLine();



        }
    }
}
