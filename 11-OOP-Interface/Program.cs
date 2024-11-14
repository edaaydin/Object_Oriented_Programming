using _11_OOP_Interface;

Console.WriteLine("Hello, World!");

IBicim bicim = new Bicim();

bicim.foo();


SQLService sqlService = new SQLService();
sqlService.Delete(5);
sqlService.Update(5);
sqlService.Create();






