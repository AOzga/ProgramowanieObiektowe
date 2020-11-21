using System;

namespace POAmadeuszOzga
{
    class ZadaniaAmadeuszOzga
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie: {0}  1) Zadanie 4.1{0}  2) Zadanie 4.2{0}  3) Zadanie 4.3" +
                "{0}  4) Zadanie 4.4{0}  5) Zadanie 4.5{0}  6) Zadanie 4.6{0}  7) Zadanie 4.7{0}  8) Zadanie 4.8" +
                "{0}  9) Zadanie 4.9{0}  10) Zadanie 4.10{0}  11) Zadanie 4.11{0}  12) Zadanie 4.12{0}  13) Zadanie 4.13" +
                "{0}  14) Zadanie 4.14{0}  15) Zadanie 4.15",Environment.NewLine);

            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.Clear();
                    Zad41();
                    break;
                case 2:
                    Console.Clear();
                    Zad42();
                    break;
                case 3:
                    Console.Clear();
                    Zad43();
                    break;
                case 4:
                    Console.Clear();
                    Zad44();
                    break;
                case 5:
                    Console.Clear();
                    Zad45();
                    break;
                case 6:
                    Console.Clear();
                    Zad46();
                    break;
                case 7:
                    Console.Clear();
                    Zad47();
                    break;
                case 8:
                    Console.Clear();
                    Zad48();
                    break;
                case 9:
                    Console.Clear();
                    Zad49();
                    break;
                case 10:
                    Console.Clear();
                    Zad410();
                    break;
                case 11:
                    Console.Clear();
                    Zad411();
                    break;
                case 12:
                    Console.Clear();
                    Zad412();
                    break;
                case 13:
                    Console.Clear();
                    Zad413();
                    break;
                case 14:
                    Console.Clear();
                    Zad414();
                    break;
                case 15:
                    Console.Clear();
                    Zad415();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Niestety, albo wprowadziłeś niewłaściwy znak na klawiaturze, albo nie ma takiego zadania.");
                    break;

            }
        }



        public static void Zad41()
        {
            
            Console.WriteLine("Podaj ile miejsc ma mieć tablica");
            int x = int.Parse(Console.ReadLine());
            int[] tab = new int[x];
            int i = 0;
            while (i < x)
            {
                Console.WriteLine("Podaj wartość {0} miejsca w tablicy", i+1);
                tab[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.Clear();
            for (var y = 0; y < tab.Length; y++)
            {
                
                Console.WriteLine("Wartość {0} miejsca w tablicy, wynosi {1}",y+1,tab[y]);
            }
        }
        public static void Zad42()
        {
            int[] tab1 = { -2, -3, -5, 6, 2, 3, 5, -16, 16, 0 };
            int[] tab2 = new int[10];

            int counter = 0;

            for (var i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[counter++] = tab1[i];
                }
            }
            for (var y = 0; y < tab2.Length; y++)
            {
                if (tab2[y] != 0) { Console.WriteLine(tab2[y]); }
            }
        }
        public static void Zad43()
        {

            double total = 0;
            Console.WriteLine("Podaj ile miejsc ma mieć tablica");
            int x = int.Parse(Console.ReadLine());
            int[] tab = new int[x];
            int i = 0;
            while (i < x)
            {
                Console.WriteLine("Podaj wartość {0} miejsca w tablicy", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int min = tab[0];
            int max = tab[0];

            for (var y = 0; y < tab.Length; y++)
            {
                if(min > tab[y]) { min = tab[y]; }
                if (max < tab[y]) { max = tab[y]; }
                total += tab[y];
            }
            Console.Clear();
            Console.WriteLine("Najmniejsza wartość to {0}", min);
            Console.WriteLine("Najwieksza wartość to {0}", max);
            Console.WriteLine("Średnia wartość indeksów w tabeli jest równa {0}", total / tab.Length);


        }
        public static void Zad44()
        {
            int[] wyniki = new int[100];
            int[] tab = new int[100];
            int counter = 0;

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
                tab[i] = rand.Next(1, 1000);

            for (int i=0; i < 100; i++)
            {
                bool test = true;
                for (int y=2; y < Math.Sqrt(tab[i]); y++)
                {
                    Console.WriteLine("y={0}     i={1}      val i ={2}",y,i,tab[i]);
                    if (tab[i] % y == 0)
                    {
                        Console.WriteLine("{0} NIE JEST LP", tab[i]);
                        test = false;
                        break;
                    }
                }

                if (test) 
                {
                    wyniki[counter++] = tab[i];
                };
            }

            Console.WriteLine("W LOSOWYM ZESTAWIE BYŁO {0} LICZB PIERWSZYCH ",counter);

            for(int i = 0; i < wyniki.Length; i++)
            {
                if (wyniki[i] != 0)
                {
                    Console.Write(wyniki[i] + "  ");
                }

            }

        }
        public static void Zad45()
        {
            Random rand = new Random();
            int x = rand.Next(1,25);
            int[] tab1 = new int[x];
            int[] tab2 = new int[x];


            for(int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = rand.Next(1,1024);
            }

            for(int i = 0; i < tab2.Length;i++)
            {
                if(i+1 == tab2.Length)
                {
                    tab2[0] = tab1[i];
                }
                else
                {
                    tab2[i + 1] = tab1[i];
                }
            }

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("tab[{1}] = {0,4}", tab1[i],i);
            }
            Console.WriteLine("");
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine("tab2[{1}] = {0,4}", tab2[i], i);
            }


        }
        public static void Zad46()
        {
            int[,] tab = new int[5,5];
            int suma = 0;
            Random rand = new Random();

            for(int i = 0; i < 5; i++)
            {
                for(int y = 0; y < 5; y++)
                {
                    tab[i, y] = rand.Next(1,100);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                for (int y = 0; y < 5; y++)
                {

                    if (i == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,5}", tab[i, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0,5}", tab[i, y]);
                    }
                    
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                suma += tab[i, i];
            }
            Console.WriteLine("Suma elementów na przekątnej jest równa {0}", suma);
            
        }
        public static void Zad47()
        {
            Random rand = new Random();
            int[,] tab1 = new int[2,3];
            int[,] tab2 = new int[2,3];
            int[,] tab3 = new int[2, 3];


            for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tab1[i, y] = rand.Next(1, 1000);
                    tab1[i, y] = rand.Next(1, 1000);
                    tab3[i, y] = tab1[i, y] + tab2[i, y];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("");
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("{0,5}", tab3[i, y]);

                }
            }


        }
        public static void Zad48()
        {
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3];
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[2, 0] = "sroda";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[4, 0] = "piatek";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[6, 0] = "niedziela";


            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[6, 1] = "sunday";


            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 2] = "sonntag";

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("");
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("{0,12}", dniTygodnia[i, y]);
                }
            }

        }
        public static void Zad49()
        {
            string text = "Abbabbabbababb bbb b bb b b       bbbbbb b b  b b b bbbb  b bb bb b b b bb  bbbb b b b b    bbbbb b b b";
            int counter = 0;
            int index = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index]))
            {
                index++;
            }
            
            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                {
                    index++;
                }  
                counter++;
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
            }
            Console.WriteLine(counter);


        }
        public static void Zad410()
        {
            string x = Console.ReadLine();
            char[] co = new char[2];

            for (int i = 0; i < 2; i++)
            {
                co[i] = x[i+3];
            }
            string b = new string(co);
            int c = int.Parse(b);

            switch (c)
            {
                case 1:
                    Console.WriteLine("styczen");
                    break;
                case 2:
                    Console.WriteLine("luty");
                    break;
                case 3:
                    Console.WriteLine("marzec");
                    break;
                case 4:
                    Console.WriteLine("kwiecien");
                    break;
                case 5:
                    Console.WriteLine("maj");
                    break;
                case 6:
                    Console.WriteLine("czerwiec");
                    break;
                case 7:
                    Console.WriteLine("lipiec");
                    break;
                case 8:
                    Console.WriteLine("sierpien");
                    break;
                case 9:
                    Console.WriteLine("wrzesien");
                    break;
                case 10:
                    Console.WriteLine("pazdziernik");
                    break;
                case 11:
                    Console.WriteLine("listopad");
                    break;
                case 12:
                    Console.WriteLine("grudzien");
                    break;

                default:
                    Console.WriteLine("Wprowadz date w formacie DD-MM-RRRR");
                    break;
            }

        }
        public static void Zad411()
        {
            string x = Console.ReadLine();
            while (x.Length > 0)
            {
                Console.Write(x[0] + " = ");
                int y = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[0] == x[i])
                    {
                        y++;
                    }
                }
                Console.WriteLine(y);
                x = x.Replace(x[0].ToString(), string.Empty);
            }
        }
        public static void Zad412()
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
             "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
             "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
             "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
             "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            Console.WriteLine(tekst);
            int wiersze = tekst.Split("\n").Length;
            Console.WriteLine("\n liczba wierszy jest równa {0}", wiersze);

            string[] tab = tekst.Split("\n");


            for (int i = 0; i < wiersze; i++)
            {

                Console.WriteLine("Liczba znaków(bez spacji) w wierszu {0} jest rowna {1}", i+1, tab[i].Replace(" ", "").Length);
            }



        }
        public static void Zad413()
        {
            string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            int slowa = 0;
            int index = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;
            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
                slowa++;
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
            }
            Console.WriteLine(slowa);


        }
        public static void Zad414()
        {

        }
        public static void Zad415()
        {

        }

    }
}
