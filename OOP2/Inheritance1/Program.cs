
//Kalıtım ile ilgili 2 örnek polimorfizm içinde bulunmaktadır.
using Inheritance1;

Teacher teacher = new Teacher();
teacher.Name = "Merve";
teacher.Surname = "Karataş";
teacher.Age = 27;
teacher.Gender = "Kadın";
teacher.Position = "Müdür";
teacher.Salary = 30000;
teacher.Branch = "Matematik";

Console.WriteLine(teacher.Name);
Console.WriteLine(teacher.Surname);
Console.WriteLine(teacher.Age);
Console.WriteLine(teacher.Gender);
Console.WriteLine(teacher.Position);
Console.WriteLine(teacher.Salary);
Console.WriteLine(teacher.Branch);