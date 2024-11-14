using _18_OOP_Serialize;
using System;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;
Person person = new Person() { Id = 1, Age = 23, Name = "Zafer", Surname = "Dörter" };

Doviz doviz = new Doviz();
doviz.Id = 1;
doviz.Name = "ABD Doları";
doviz.Price = 34.5;

// @ verbatim 
string path = @"person.json";

string json = JsonSerializer.Serialize(person);
Console.WriteLine(json);
WriteToFile(json, path);

// JSON Deserialize
Person person1 = JsonSerializer.Deserialize<Person>(ReadFromFile(path));
Console.WriteLine(person1.Name);
Console.WriteLine(person1.Surname);
Console.WriteLine(person1.Age);


// XML Serialize
string xml = SerializeToXML<Doviz>(doviz);
Console.WriteLine(xml);
WriteToFile(xml, "doviz.xml");

// XML Deserialize
string xmlFromFile = ReadFromFile("doviz.xml");
Doviz dolar = DeserializeXML<Doviz>(xmlFromFile);
Console.WriteLine(dolar.Id);
Console.WriteLine(dolar.Name);
Console.WriteLine(dolar.Price);


string SerializeToXML<T>(T obj)
{
    try
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        using (StringWriter sw = new StringWriter())
        {
            xmlSerializer.Serialize(sw, obj);
            return sw.ToString();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata oluştu : " + ex.Message);
        return null;
    }
}

T DeserializeXML<T>(string xml)
{
    try
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StringReader sr = new StringReader(xml))
        {
            return (T)serializer.Deserialize(sr);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata Oluştu: " + ex.Message);
        throw;
    }
}

string ReadFromFile(string filePath)
{
    try
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            return sr.ReadToEnd();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata oluştur");
        return null;
    }
}

void WriteToFile(string metin, string filePath)
{
    try
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.Write(metin);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Hata oluştu: {ex.Message}");
    }
}