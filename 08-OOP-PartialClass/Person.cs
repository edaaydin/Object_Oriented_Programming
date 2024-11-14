namespace _08_OOP_PartialClass
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
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
