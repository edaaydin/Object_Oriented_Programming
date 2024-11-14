using System.Runtime;

namespace _04_OOP_LAB
{
    internal class Utu
    {
        private Guid _id;
        private string _name;
        private bool _kazanliMi;
        private int _derece;
        private int _suOrani;
        private DateTime _garanti;

        public Utu(string name, bool kazanliMi)
        {
            _name = name;
            _id = Guid.NewGuid();
            _kazanliMi = kazanliMi;
            _derece = 20;
        }

        // propfull tab tab 

        public DateTime Garanti
        {
            get { return _garanti; }
            private set { _garanti = value; }
        }

        public int SuOrani
        {
            get { return _suOrani; }
            set
            {
                if (value > 0 && value < 1000)
                    _suOrani = value;
                else
                    Console.WriteLine("Su oranı 0 dan küçük 1000 den büyük olamaz.");

            }
        }

        public int Derece
        {
            get { return _derece; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _derece = value;
                }
                else
                {
                    Console.WriteLine("Derece 0 dan küçük 100 den büyük olamaz.");
                }
            }
        }

        public bool KazanliMi
        {
            get { return _kazanliMi; }
            set { _kazanliMi = value; }
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public bool Isin()
        {
            Derece += 10;
            SuOrani -= 100;

            int sicaklik = SuKontrol();
            SonDurum();

            return !(sicaklik < 10);
        }

        private void SonDurum()
        {
            Console.WriteLine($"Isı: {Derece} Su: {SuOrani}");
        }

        private int SuKontrol()
        {
            if (SuOrani < 300 && SuOrani > 100)
                Console.WriteLine($"Dikkat Et!!! Su azalıyor.");
            else if (SuOrani <= 100)
            {
                Console.WriteLine("Su bitti makine kendini kapattı. Devam etmek için su eklemelisin");
                Derece = 5;
            }
            return Derece;
        }

        public void GenelBilgiGoster()
        {
            Console.WriteLine($"Id: {Id} Markası: {Name} Kazanli mi: {KazanliMi} Garanti: {Garanti}");
        }



    }
}
