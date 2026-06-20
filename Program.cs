using OOPS.Abstraction;
using OOPS.Encapsulation;
using OOPS.Inheritance.Hierarchical;
using OOPS.Inheritance.Multi_level;
using OOPS.Inheritance.Single_level;
using OOPS.Interface;
using OOPS.OOPS_Basics;
using OOPS.Polymorphism;
using System.Xml.Linq;

//Student s = new Student();
//Student s4 = new Student();
//Student1 s3 = new Student1();
//Student1 s2 = new Student1(102,"Rani");
//Console.WriteLine("Id : "+s2.id);
//Console.WriteLine("Name : "+s2.name);

//Console.WriteLine("=== Encapsulation ===");
//Employee emp = new Employee();
//emp.setId(1);
//emp.setName("Anu");
//emp.setSalary(20000);

//Console.WriteLine("Id : "+emp.getId());
//Console.WriteLine("Name : " + emp.getName());
//Console.WriteLine("salary : " + emp.getSalary());
//Console.WriteLine(emp);

//Students s = new Students();
//s.Id = 111;
//s.Name = "Prasad";
//s.Marks = -29;
//Console.WriteLine("Student Id : "+s.Id);
//Console.WriteLine("Student Name : " + s.Name);
//Console.WriteLine("Student Marks : " + s.Marks);

//Car car = new Car();
//car.brand = "Audi";
//car.carId = 1001;
//Console.WriteLine("Car Id : " + car.carId);
//Console.WriteLine("Car Brand : " + car.brand);

Console.WriteLine("=== Inheritance ===");
Bike b = new Bike();
b.brand = "Yamaha";
b.wheels = 2;
b.Start();
Console.WriteLine("Brand : "+b.brand);
Console.WriteLine("Wheels : " + b.wheels);
b.Stop();

Console.WriteLine("================");
Dog dog = new Dog();
dog.AnimalName = "Puppy";
dog.NoOfLegs = 4;
Console.WriteLine("Animal Name : "+dog.AnimalName);
Console.WriteLine("Animal Legs : "+dog.NoOfLegs);
dog.Sound();

Console.WriteLine("================");
Team team = new Team();
team.CompanyName = "SNAD Developers";
team.DepartmentName = "Engineering Department";
team.members = 33;
Console.WriteLine("Company Name = " + team.CompanyName+", Department Name = "+team.DepartmentName+", Team Members = "+team.members);
team.CompanyInfo();
team.DepartmentInfo();
team.Teaminfo();

Console.WriteLine("================");
Developer d = new Developer();
Tester t = new Tester();
d.Name = "Pavan";
t.Name = "Akhil";
Console.WriteLine("== Developer Details ==");
d.Login();
Console.WriteLine("Developer Name = " + d.Name);
d.Code();

Console.WriteLine("== Tester Details ==");
t.Login();
Console.WriteLine("Tester Name = " + t.Name);
t.Test();

Console.WriteLine("================");
ConstructorChaining c = new ConstructorChaining("Name",1,65);

Console.WriteLine(c.Name);
Console.WriteLine(c.id);
Console.WriteLine(c.marks);

Console.WriteLine("================");
MethodOverLoading m = new MethodOverLoading();

Console.WriteLine(m.Add(10));
Console.WriteLine(m.Add(20, 30));
Console.WriteLine(m.Add(30, 60, 10));

Console.WriteLine("================");
A m2 = new A();
m2.Method();
MethodOverriding m3 = new A();
m3.Method();

B b2 = new B();
b2.Method();

Console.WriteLine("================");
V v = new V();
v.Start();
v.Stop();

Console.WriteLine("========= Interfaces =========");
Swiggy s = new Swiggy();
s.ProcessPayment(new PhonePo());
s.ProcessPayment(new GooglePay());


