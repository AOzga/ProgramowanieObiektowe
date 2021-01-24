using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxxxx
{
    public class Program
    { 
        static void Main()
        {

        }
    }
    public abstract class Usluga
    {
        public Usluga(DateTime x)
        {
            this.czas = x;
        }   
        protected DateTime czas;
        protected double cena;

        public abstract void ObliczCene();
    }

    public class Polaczenie : Usluga
    {
        private string numer;
        private int czasP;

        public Polaczenie(DateTime x) : base(x) => this.czas = x;

        public override void ObliczCene() => this.cena = czasP * 0.28;
        public Polaczenie(DateTime x, string y, int z) : base(x)
        {
            this.czas = x;
            this.numer = y;
            this.czasP = z;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Połączenie: numer " + this.numer + " , data i godzina rozmowy:" + this.czas + " , długość trwania: " + this. czasP+ " , łączny koszt:" + this.cena;
        }


    }
    public class Sms : Usluga
    {
        private string numer;

        public override void ObliczCene() => this.cena = 0.14;

        public Sms(DateTime x, string y) : base(x)
        {
            this.czas = x;
            this.numer = y;
            ObliczCene();
        }

        public override string ToString()
        {
            return this.czas + " numer : " + this.numer + "cena : " + this.cena + "";
        }
    }

    public class Internet : Usluga
    {
        private int iloscMb;

        public override void ObliczCene()
        {
            this.cena = Math.Round(iloscMb / 756.0, 2);
        }
        public Internet(DateTime x, int y) : base(x)
        {
            this.czas = x;
            this.iloscMb = y;
            ObliczCene();
        }
        public override string ToString()
        {
            return this.czas + " " + this.iloscMb + " " + this.cena;
        }

    }
    public interface Ibilling 
    {
        void ZapiszBilling();
    }
    public interface Idodaj 
    {
        void DodajPolaczenie(string numer, int czasP);
        void DodajSms(string numer);
        void DodajInternet(int iloscMb);
    }

    public class Telefon : Idodaj
    {
        private List<Usluga> biling;

        public void DodajInternet(int iloscMb)
        {
            biling.Add(new Internet(DateTime.Now, iloscMb));
        }

        public void DodajPolaczenie(string numer, int czasP)
        {
            biling.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }

        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now, numer));
        }

        public override string ToString()
        {
            string txt = "";
            for(int i = 0; i > biling.Count; i++)
            {
                txt += (biling[i]) + Environment.NewLine;
            }
            return txt;
        }
        public void ZapiszBiling()
        {
            string txt = this.ToString();
            System.IO.File.WriteAllText(@"\WriteText.txt", txt);
        }
    }



}
