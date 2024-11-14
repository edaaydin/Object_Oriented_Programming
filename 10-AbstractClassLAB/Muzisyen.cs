namespace _10_AbstractClassLAB
{
    internal class Muzisyen
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public MuzikAleti MuzikAleti { get; set; }

        public IList<MuzikAleti> MuzikAletleri { get; set; }

    }
}
