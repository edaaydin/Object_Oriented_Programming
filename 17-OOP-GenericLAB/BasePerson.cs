namespace _17_OOP_GenericLAB
{
    internal abstract class BasePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; } = Status.Active;
        public abstract void CalculateSalary();
    }
}
