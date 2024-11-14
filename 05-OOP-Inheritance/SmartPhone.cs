namespace _05_OOP_Inheritance
{
    internal class SmartPhone : MobilePhone
    {
        public SmartPhone(bool hasCamera, bool isTouched, string brand, string connectionType, bool frontCam) : base(hasCamera, isTouched, brand, connectionType)
        {
            this.FrontCam = frontCam;
            PhoneType = "Smart Phone";

        }

        public bool FrontCam { get; set; }

        public override string Call()
        {
            return "Apple müziği";
        }

        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();
        }

        public override string ToString()
        {
            return $"Marka: {Brand} Bağlantı Tipi: {ConnectionType} Ön Kamera: {FrontCam} Arka Kamera: {HasCamera} Dokunmatik: {IsTouched}";
        }
    }
}