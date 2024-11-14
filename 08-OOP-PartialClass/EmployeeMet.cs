namespace _08_OOP_PartialClass
{
    internal partial class Employee
    {
        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Ekrana Yaz..");
        }

        public override string ToString()
        {
            return $"{ID} {Name}";
        }
    }
}
