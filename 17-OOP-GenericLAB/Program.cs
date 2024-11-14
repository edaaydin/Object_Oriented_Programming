using _17_OOP_GenericLAB;

List<int> ints = new List<int>();
List<string> strings = new List<string>();
List<object> list = new List<object>();
List<BasePerson> persons = new List<BasePerson>();
List<Employee> employees = new List<Employee>();


BaseService baseService = new BaseService();
baseService.Create(new Admin() { Id = 1, Name = "zafer", Status = Status.Active });
baseService.Create(new Admin() { Id = 2, Name = "İrem", Status = Status.Active });
baseService.Create(new Admin() { Id = 3, Name = "Taylan", Status = Status.Passive });
baseService.Create(new Employee() { Id = 4, Name = "Hamide", Status = Status.Active });
baseService.Create(new Admin() { Id = 6, Name = "Batuhan", Status = Status.Passive });

foreach (var item in baseService.GetAll())
{
    if (item.Status == Status.Active)
    {
        Console.WriteLine(item.Name + " ");
        item.CalculateSalary();
    }
}