namespace _05_OOP_Inheritance
{
    internal class MobilePhone : Phone
    {
        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType) : base(brand, connectionType)
        {
            //base.Brand = brand;
            //base.ConnectionType = connectionType;
            this.HasCamera = hasCamera;
            this.IsTouched = isTouched;
            base.PhoneType = "Mobile Phone";

        }

        //public MobilePhone()
        //{
        //    PhoneType = "Mobile Phone";
        //}

        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public string TakePhoto()
        {
            return HasCamera ? "You can take a photo" : "There is no cam";
        }

        public override string Call() // Override
        {
            return "Polifonik Müzik Cendere Cendere...";
        }

        public override string ConnectionStatus()
        {
            return "3G bağlantı...";
        }


    }
}
