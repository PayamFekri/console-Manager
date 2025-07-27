using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_of_the_fotball_project
{
    internal class club2
    {
        public void ShowMainMenu()
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tChangiz Main Menu !");
            Console.WriteLine();
            Console.WriteLine(" 1. player affairs ");
            Console.WriteLine(" 2. Coaches affairs ");
            Console.WriteLine(" 3. Emplyee affairs ");
            Console.WriteLine(" 4. financial department: ");
            Console.WriteLine(" 5. Exit ");
            Console.WriteLine(" -------------");
        }
        public void ShowfinancialdepartmentMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Option 4:");
            Console.WriteLine("1. show The Sum Salary Of Players ");
            Console.WriteLine("2. show The Sum Salary Of Couches ");
            Console.WriteLine("3. show The Sum Salary Of Employees ");
            Console.WriteLine("4. Sub-option 4");
            Console.WriteLine("5. Sub-option 5");
            Console.WriteLine("6. Sub-option 6");
            Console.WriteLine("7. Sub-option 7");
            Console.WriteLine("8. Sub-option 8");
            Console.WriteLine("9. Sub-option 9");
            Console.WriteLine("10. Back to Main Menu");
            Console.WriteLine();
        }
        public void ShowEmployeeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t1. Add New Employee ");
            Console.WriteLine("\t2. Edit Employee (by name) [doesn't action] ");
            Console.WriteLine("\t3. Name Employee Search ");
            Console.WriteLine("\t4. Remove Emplyee (by name) [doesn't action] ");
            Console.WriteLine("\t5. Show all Employee ");
            Console.WriteLine("\t6. total salary of the Emplyees [doesn't action] ");
            Console.WriteLine("\t7. Sub-option 7");
            Console.WriteLine("\t8. Sub-option 8");
            Console.WriteLine("\t9. Sub-option 9");
            Console.WriteLine("\t10. Back to Main Menu");
            Console.WriteLine();
        }

        public void ShowCouchMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t1. Add New couch ");
            Console.WriteLine("\t2. Edit couch (by name) ");
            Console.WriteLine("\t3. Name couch Search: ");
            Console.WriteLine("\t4. Remove couch (by name) ");
            Console.WriteLine("\t5. Show all couch ");
            Console.WriteLine("\t6. Sub-option 6");
            Console.WriteLine("\t7. Sub-option 7");
            Console.WriteLine("\t8. Sub-option 8");
            Console.WriteLine("\t9. Sub-option 9");
            Console.WriteLine("\t10. Back to Main Menu");
            Console.WriteLine();
        }
        public void ShowPlayerMenu()
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\t1. Add New Player");

            Console.WriteLine("\t2. Remove Player (by name)");

            Console.WriteLine("\t3. Edit Player (by name)");

            Console.WriteLine("\t4. Show All player");

            Console.WriteLine("\t5. Name Search");

            Console.WriteLine("\t6. player Field");

            Console.WriteLine("\t7. Tops Corers");

            Console.WriteLine("\t8. goals Search ");

            Console.WriteLine("\t9. Random search ");
            Console.WriteLine("\t10. Back to Main Menu");
            Console.WriteLine();
        }
        public void ShowOrderMenu2()
        {
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("\t8. Random Choise");

            Console.WriteLine("\t9. Show All");

            Console.WriteLine("\tA. Show Pleyer");

            Console.WriteLine("\tC. salary");

            Console.WriteLine("\tD. salary search : ");

            Console.WriteLine("\tE. TeamCadre");

            Console.WriteLine("\t0. Exit");
            Console.WriteLine();
        }
    }
}
