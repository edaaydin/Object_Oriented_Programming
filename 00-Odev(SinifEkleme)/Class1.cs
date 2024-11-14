namespace _00_Odev_SinifEkleme_
{
    internal class Class1
    {
        // Kisisel Bİlgiler Class'i
        private string ad;
        private string soyad;
        private string meslek;
        private int yas;


        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }
        public string Meslek { get { return meslek; } set { meslek = value; } }
        public int Yas { get { return yas; } set { yas = value; } }


        // Universite Bİlgileri class'i
        private int okulNo;
        private string okulAdi;
        private int mezunYili;
        private string bolum;


        public int OkulNo { get { return okulNo; } set { okulNo = value; } }
        public string OkulAdi { get { return okulAdi; } set { okulAdi = value; } }
        public int MezunYili { get { return mezunYili; } set { mezunYili = value; } }
        public string Bolum { get { return bolum; } set { bolum = value; } }

        // Mutfak Class'i

        private string meyveAdi;
        private string sebzeAdi;
        private string yesillikAdi;
        private string baklagiller;

        public string Baklagiller { get { return baklagiller; } set { baklagiller = value; } }

        public string YesillikAdi { get { return yesillikAdi; } set { yesillikAdi = value; } }

        public string SebzeAdi { get { return sebzeAdi; } set { sebzeAdi = value; } }

        public string MeyveAdi { get { return meyveAdi; } set { meyveAdi = value; } }

        //  Bilgisayar Markasi Class'ı

        private string aMarka;
        private string bMarka;
        private string cMarka;

        public string AMarka { get { return aMarka; } set { aMarka = value; } }
        public string BMarka { get { return bMarka; } set { bMarka = value; } }
        public string CMarka { get { return cMarka; } set { cMarka = value; } }

        // Giyim Class'i

        private string ustGiyim;
        private string altGyim;
        private int ayakkabiNo;
        private string disGiyim;

        public string UstGiyim { get { { return ustGiyim; } } set { ustGiyim = value; } }
        public string AltGiyim { get { { return altGyim; } } set { altGyim = value; } }
        public int AyakkabiNo { get { { return ayakkabiNo; } } set { ayakkabiNo = value; } }
        public string DisGiyim { get { return disGiyim; } set { disGiyim = value; } }




    }
}
