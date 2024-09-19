using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    //    Exercise 1: Basic Inheritance
    //Objective: Create a base class and a derived class.
    //Create a base class called Person with the following properties and methods:
    //Properties: Name(string), Age(int)
    //Method: DisplayInfo(), which prints the name and age.
    //Create a derived class called Student that inherits from Person and adds the following:
    //Property: StudentID(string)
    //Method: DisplayStudentInfo(), which prints the name, age, and student ID.
    //Instantiate a Student object, set its properties, and call both DisplayInfo() and DisplayStudentInfo().

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | Age:{Age}");
        }
    }

    class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string name, int age, string studentId) : base(name, age)
        {
            StudentId = studentId;
        }



        public void DisplayStudentinfo()
        {

            DisplayInfo();
            Console.WriteLine($"StudentId: {StudentId}");
        }
    }


    //    Exercise 2: Employee and Manager
    //Objective: Create a base class and a derived class.
    //Create a base class called Employee with the following properties and methods:
    //Properties: Name(string), Salary(double)
    //Method: DisplayEmployeeInfo(), which prints the name and salary.
    //Create a derived class called Manager that inherits from Employee and adds the following:
    //Property: Department(string)
    //Method: DisplayManagerInfo(), which prints the name, salary, and department.
    //Instantiate a Manager object, set its properties, and call both DisplayEmployeeInfo() and DisplayManagerInfo().

    class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name:{Name} | Salary:{Salary}");
        }
    }

    class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(string name, double salary, string department) : base(name, salary)
        {
            Department = department;
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Department:{Department}");
        }
    }


    //    Exercise 3: Vehicle and Car
    //Objective: Create a base class and a derived class.
    //Create a base class called Vehicle with the following properties and methods:
    //Properties: Make(string), Model(string)
    //Method: DisplayVehicleInfo(), which prints the make and model.
    //Create a derived class called Car that inherits from Vehicle and adds the following:
    //Property: NumberOfDoors(int)
    //Method: DisplayCarInfo(), which prints the make, model, and number of doors.
    //Instantiate a Car object, set its properties, and call both DisplayVehicleInfo() and DisplayCarInfo().


    class Vehicle
    {
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }


        public void DisplayVehicleInfo()
        {
            Console.WriteLine($"Make: {Make} |Model: {Model}");
        }
    }


    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string make, string model, int numberofdoors) : base(make, model)
        {
            NumberOfDoors = numberofdoors;
        }

        public void DisplayCarInfo()
        {
            DisplayVehicleInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }


    //    Exercise 4: Animal and Dog
    //Objective: Create a base class and a derived class.
    //Create a base class called Animal with the following properties and methods:
    //Properties: Species(string), Age(int)
    //Method: DisplayAnimalInfo(), which prints the species and age.
    //Create a derived class called Dog that inherits from Animal and adds the following:
    //Property: Breed(string)
    //Method: DisplayDogInfo(), which prints the species, age, and breed.
    //Instantiate a Dog object, set its properties, and call both DisplayAnimalInfo() and DisplayDogInfo().

    class Animal
    {
        public Animal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        public string Species { get; set; }
        public int Age { get; set; }


        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Species: {Species} | Age: {Age}");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string species, int age, string breed) : base(species, age)
        {
            Breed = breed;
        }

        public void DisplayDogInfo()
        {
            DisplayAnimalInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }


    //    Exercise 5: Appliance and WashingMachine
    //Objective: Create a base class and a derived class.
    //Create a base class called Appliance with the following properties and methods:
    //Properties: Brand(string), Power(int)
    //Method: DisplayApplianceInfo(), which prints the brand and power.
    //Create a derived class called WashingMachine that inherits from Appliance and adds the following:
    //Property: LoadCapacity(int)
    //Method: DisplayWashingMachineInfo(), which prints the brand, power, and load capacity.
    //Instantiate a WashingMachine object, set its properties, and call both DisplayApplianceInfo() and DisplayWashingMachineInfo().





    //    Objective: Create a base class and a derived class.
    //Create a base class called Book with the following properties and methods:
    //Properties: Title(string), Author(string)
    //Method: DisplayBookInfo(), which prints the title and author.
    //Create a derived class called EBook that inherits from Book and adds the following:
    //Property: FileSize(double)
    //Method: DisplayEBookInfo(), which prints the title, author, and file size.
    //Instantiate an EBook object, set its properties, and call both DisplayBookInfo() and DisplayEBookInfo().






    //Exercise 7: Shape and Rectangle
    //Objective: Create a base class and a derived class.
    //Create a base class called Shape with the following properties and methods:
    //Property: Color(string)
    //Method: DisplayShapeInfo(), which prints the color.
    //Create a derived class called Rectangle that inherits from Shape and adds the following:
    //Properties: Width(double), Height(double)
    //Method: DisplayRectangleInfo(), which prints the color, width, and height.
    //Instantiate a Rectangle object, set its properties, and call both DisplayShapeInfo() and DisplayRectangleInfo().






    //Exercise 8: BankAccount and SavingsAccount
    //Objective: Create a base class and a derived class.
    //Create a base class called BankAccount with the following properties and methods:
    //Properties: AccountNumber(string), Balance(double)
    //Method: DisplayAccountInfo(), which prints the account number and balance.
    //Create a derived class called SavingsAccount that inherits from BankAccount and adds the following:
    //Property: InterestRate(double)
    //Method: DisplaySavingsAccountInfo(), which prints the account number, balance, and interest rate.
    //Instantiate a SavingsAccount object, set its properties, and call both DisplayAccountInfo() and DisplaySavingsAccountInfo().






    //Exercise 9: Employee and Developer
    //Objective: Create a base class and a derived class.
    //Create a base class called Employee with the following properties and methods:
    //Properties: Name(string), Position(string)
    //Method: DisplayEmployeeInfo(), which prints the name and position.
    //Create a derived class called Developer that inherits from Employee and adds the following:
    //Property: ProgrammingLanguage(string)
    //Method: DisplayDeveloperInfo(), which prints the name, position, and programming language.
    //Instantiate a Developer object, set its properties, and call both DisplayEmployeeInfo() and DisplayDeveloperInfo().




    //Exercise 10: MusicalInstrument and Guitar
    //Objective: Create a base class and a derived class.
    //Create a base class called MusicalInstrument with the following properties and methods:
    //Properties: Name(string), Type(string)
    //Method: DisplayInstrumentInfo(), which prints the name and type.
    //Create a derived class called Guitar that inherits from MusicalInstrument and adds the following:
    //Property: NumberOfStrings(int)
    //Method: DisplayGuitarInfo(), which prints the name, type, and number of strings.
    //Instantiate a Guitar object, set its properties, and call both DisplayInstrumentInfo() and DisplayGuitarInfo().



    class Course
    {
        public string CourseName { get; set; }
        public int Credits
        {
            get
            {
                return Credits;
            }
            set
            {
                if (value >= 6 || value <= 1)
                {
                    throw new Exception("Credit must be from 1 to 6 ");
                }

                Credits = value;
            }



        }

        class Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void GetFullName()
            {
                Console.WriteLine($"FirtsName: {FirstName} | LastName:{LastName}");
            }


            public


        }

        class Teacher : Person
        {
            public string Subject { get; set; }
            public Teacher(string firtsName, string lastName,string subject) : base(firtsName,lastName) {

                Subject= subject;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {


                //Student st1 = new Student("Anna", 20, "A20");
                //st1.DisplayStudentinfo();



                //Manager man1 = new Manager("Keyl", 500, "Accounting");
                //man1.DisplayManagerInfo();



                //Car car1 = new Car("Volvo", "Opel", 4);
                //car1.DisplayCarInfo();


                //Dog dog1 = new Dog("Xaski", 5, "Nobreed");
                //dog1.DisplayDogInfo();

                Console.ReadLine();
            }

        }
    }
