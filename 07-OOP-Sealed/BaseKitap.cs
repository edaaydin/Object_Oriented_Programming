namespace _07_OOP_Sealed
{
    // Base Sınıf
    internal class BaseKitap
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public virtual void GetLog()
        {
            Console.WriteLine("Log Kayıt Başladı");
        }

        public virtual void GetUser()
        {
            Console.WriteLine("Kullanıcı Bilgileri Getiriliyor..");
        }
    }
}
