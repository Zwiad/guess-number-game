using System;

    namespace Game
{
    class Program
    {
        public static bool zgadnieta = false;
        public static bool dzialanie = true;
        static int Main(string[] args)
        {

            

                Game g = new Game();

                g.Generowanie();

                g.Komunikat();

            do
            {

                do
                {

                    g.zgadywanie();

                } while (zgadnieta == false);

            } while (dzialanie == true);

            return 0;
        }
    }
    class Game
    {
        private int num;
        private int decyzja;
        public void Komunikat()
        {

            Console.WriteLine("Zgadnij liczbę całkowitą z zakresu od 0 do 100");

        }

        public void Generowanie()
        {

            Random rng = new Random();

            num = rng.Next(0, 100);

        }
        public void zgadywanie()
        {

            int liczba = Convert.ToInt32(Console.ReadLine());
            

            if (liczba == num)
            {

                Console.WriteLine("Gratulacje! Zgadłeś/aś liczbę!");

                Program.zgadnieta = true;

                Console.WriteLine("Czy chcesz zagrać jeszcze raz? \n 1. TAK \n2. NIE");

                decyzja = Convert.ToInt32(Console.ReadLine());

                if (decyzja == 1)
                {
                    Program.zgadnieta = false;

                    Generowanie();

                    Komunikat();

                }
                else if (decyzja == 2)
                {
                    Program.dzialanie = false;
                }

            }
            else if (liczba < num)
            {

                Console.WriteLine("Zgadywana liczba jest większa");

            }
            else if (liczba > num)
            {

                Console.WriteLine("Zgadywana liczba jest mniejsza");

            }
        }
    }
};
