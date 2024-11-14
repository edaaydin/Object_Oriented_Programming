using _02_OOP_Constructor;

//Car car = new Car(); // Nesne oluşturuyorum.

//car.Brand = "Ford";
//car.Model = "Focus";
//car.Engine = 1500;


Car car2 = new Car("BMW");
car2.Model = "Z4";
car2.Engine = 2000;


Car car3 = new Car("Volswagen", "T-Roc");
car3.Engine = 1500;

Car car4 = new Car("ReNaUlT", "Megan", 1600);

Car car5 = new Car() { Model = "A180", Engine = 1800 };

//Console.WriteLine($"{car.Brand} {car.Model} {car.Engine}");

Console.WriteLine($"{car2.Brand} {car2.Model} {car2.Engine}");

Console.WriteLine($"{car3.Brand} {car3.Model} {car3.Engine}");

Console.WriteLine($"{car4.Brand} {car4.Model} {car4.Engine}");

Console.WriteLine($"{car5.Brand} {car5.Model} {car5.Engine}");