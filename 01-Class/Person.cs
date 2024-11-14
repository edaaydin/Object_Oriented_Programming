namespace _01_OOP_Class
{
    // Basitçe tanımlamak gerekirse Class (sınıf), Nesneleri oluşturmak için kullanılan şablonlardır.
    // Sınıf - Class
    // Nesne - Object

    internal class Person
    {
        // Temel olarak Members - Üyeler
        // Constructor (Yapıcı Metot),
        // Fields (Alanlar),
        // Properties (Özellikler)
        // Methods (Metotlar)
        // Event, Delegate ve Struct

        // Default Constructor Method
        //Person() {}

        //public int Id;
        //public string Name;
        //public string Surname;
        //public int Age;
        //private double Salary;  sadece içerden erişim olur

        // Fields 
        private string _name;
        private int _age;
        private string _surname;

        // Properties
        // prop + tab + tab
        public string Name { get; set; }

        #region III.Yöntem

        //public int Age { get; set; } 
        #endregion

        #region I. Yöntem

        //public int GetAge()
        //{
        //    return _age;
        //}

        //public void SetAge(int value)
        //{
        //    if (value > 18 && value < 100)
        //        _age = value;
        //    else
        //        throw new Exception("Çocuk İşçi Yassak!");
        //}
        #endregion

        #region II. Yöntem

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18)
                    _age = value;
                else
                    Console.WriteLine("Kullanıcı yaşı 18'den küçük olamaz");
            }
        }

        #endregion

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value.ToUpper();
            }
        }
    }
}
