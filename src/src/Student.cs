using System.Diagnostics;
using System.Xml.Linq;

namespace src;

public class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public string UniversityName { get; set; }
  
    public void DisplayInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"SeconName: {SecondName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"UniversityName: {UniversityName}");
    }  
}
