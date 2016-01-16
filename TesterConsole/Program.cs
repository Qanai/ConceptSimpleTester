using System;
using TestFields.ClassInheritance;

namespace TesterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowStartMenu();
        }

        private static void ShowStartMenu()
        {
            Person basic = new Person()
            {
                Name = "John",
                Surname = "Smith",
                DateOfBirth = new DateTime(1971, 5, 28)
            };

            Person f = new Activist()
            {
                Name = "Bill",
                Surname = "Conwell",
                DateOfBirth = new DateTime(1984, 3, 8),
                DepartmentGroup = "Media"
            };

            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
