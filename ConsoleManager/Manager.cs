using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFields.ClassInheritance;

namespace ConsoleManager
{
    public class Manager
    {
        public void TestInheritance() 
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
        }

        public void ShowStartMenu()
        {
            Console.Clear();
            List<string> menu = new List<string>() 
            {
                "Inheritance"
            };

            string startCoice = DisplayMenu(menu);

            ShowSubMenu(startCoice);
        }

        private void ShowSubMenu(string startCoice)
        {
            switch (startCoice)
            {
                case "1":
                    Console.WriteLine("IN");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

        private string DisplayMenu(List<string> menuData)
        {
            menuData.ForEach
                (
                    md => Console.WriteLine(string.Format("{0}. {1}", menuData.IndexOf(md) + 1, md))
                );
            Console.WriteLine();
            Console.Write("Please enter your choice: ");

            return Console.ReadLine();
        }

    }
}
