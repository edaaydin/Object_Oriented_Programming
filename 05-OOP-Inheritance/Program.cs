using _05_OOP_Inheritance;

Phone basePhone = new Phone("AEG", "Kablolu Bağlantı");


//basePhone.Brand = "AEG";
//basePhone.ConnectionType = "Kablolu Bağlantı";
Console.WriteLine(basePhone.Call());

Console.WriteLine($"{basePhone.Brand} - {basePhone.PhoneType} - {basePhone.ConnectionType} ");


//MobilePhone mobilePhone = new MobilePhone();

//mobilePhone.Brand = "Nokia";
//mobilePhone.ConnectionType = "3G";
//mobilePhone.HasCamera = true;
//mobilePhone.IsTouched = true;

MobilePhone mobilePhone = new MobilePhone(true, true, "Nokia", "3G");

Console.WriteLine($"{mobilePhone.Brand} - {mobilePhone.PhoneType} - {mobilePhone.ConnectionType} - {mobilePhone.HasCamera} - {mobilePhone.IsTouched} ");

Console.WriteLine(mobilePhone.Call());
Console.WriteLine(mobilePhone.ConnectionStatus());

SmartPhone smartPhone = new SmartPhone(true, true, "Apple", "5G", true);

Console.WriteLine(smartPhone.Call());
Console.WriteLine(smartPhone.ConnectionStatus());
Console.WriteLine(smartPhone);
Console.WriteLine(smartPhone.ToString());

