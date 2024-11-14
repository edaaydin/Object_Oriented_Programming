namespace _05_OOP_Inheritance
{
    internal class Phone
    {
        private string _brand;
        protected string _phoneType;
        private string _connectionType;

        //     public Phone()
        //     {
        //         _phoneType = "Ahizeli Telefon";	
        //     }

        public Phone(string brand, string connectionType)
        {
            _brand = brand;
            _connectionType = connectionType;
        }

        protected internal string Brand
        {
            get { return _brand; }
            private set { _brand = value; }
        }

        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }

        public string ConnectionType
        {
            get { return _connectionType; }
            set { _connectionType = value; }
        }

        public virtual string Call()
        {
            return "Ahizeli Telefon Çalıyor...";
        }

        public virtual string ConnectionStatus()
        {
            return "Kablolu Bağlantısı Mevcut";
        }

    }
}
