using System.Buffers.Binary;

namespace _5M04konForum
{
    /************************************
     * nazwa klasy:     Osoba
     * pola:            id - prywatnr pole określające id osoby, numeryczne
     *                  imie - prywatne pole określające imie osoby,string
     *                  liczbaInstancji - publiczne statyczne pole przechowujące liczbę instancji
     *                      obiektów klasy Osoba
     * metody:          Osoba() - konstruktor bezargumentowy
     *                  Osoba(int id, string imie) - knstruktor z dwoma parametrami 
     *                      ustawiający wartości id i imie
     *                  Osoba(Osoba osoba) - konstruktor kopiujący
     * informacje:      klasa ma być wykorzystana w Forum
     * autor:           mm
     * ************************************/
    class Osoba
    {
        private int id;
        private string imie;
        public static int liczbaInstancji = 0;
        public Osoba()
        {
            id = 0;
            imie = "";
            liczbaInstancji++;
        }
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            liczbaInstancji++;
        }
        public Osoba(Osoba osoba)
        {
            this.id =osoba.id;
            this.imie=osoba.imie;
            liczbaInstancji++;
        }
        /*************************************
         * nazwa funkcji:       wypiszImie
         * argumenty:           imiePrzekazane - imię innej osoby
         * typ zwracany:        brak
         * informacjje:         Metodę do wypisania imienia obiektu 
         *                      klasy Osoba w postaci: „Cześć <argument>, 
         *                      mam na imię  <imie>”,  gdzie  pole  
         *                      <argument>  jest  innym  imieniem  
         *                      przekazanym  jako  parametr wejściowy 
         *                      metody. Jeżeli w obiekcie nie 
         *                      wypełniono wartości pola z imieniem 
         *                      wyświetlany jest komunikat „Brak danych”.
         * autor:               mm
         * **********************************/

        public void wypiszImie(string imiePrzekazane)
        {
            if (imie.Length > 0)
                Console.WriteLine($"cześć {imiePrzekazane}, mam na imie {imie}");
            else
                Console.WriteLine("brak danych");
        }
             
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Liczba zarejestrowanych osób: {Osoba.liczbaInstancji}");
            Osoba osoba1 = new Osoba();
            Console.Write("Podaj numer osoby: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("podaj imię: ");
            string imie = Console.ReadLine();
            Osoba osoba2 = new Osoba(id, imie);
            Osoba osoba3 = new Osoba(osoba2);
            Console.WriteLine($"Liczba zarejestrowanych osób: {Osoba.liczbaInstancji}");
            osoba1.wypiszImie("mm");
            osoba2.wypiszImie("mm");
            osoba3.wypiszImie("mm");
        }
    }
}
