using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_of_the_fotball_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            club c = new club();
            club2 c1 = new club2();
            players p = new players();
            Readsndwrite1 r1= new Readsndwrite1();
            financial_department fd= new financial_department();
            Couching couching= new Couching();
            employee1 e1 = new employee1();
            WritingandLoading wl = new WritingandLoading();
            Readandwrite2 WritingandLoading = new WritingandLoading ();
            Readsndwrite1 rw= new Readsndwrite1();

            string choice = "";
            while (choice != "5")
            {
                Console.Clear();
                c1.ShowMainMenu();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                wl.loadfromfile2("Coach.txt");
                rw.loadfromfile1("Player.txt");
                switch (choice)
                {
                    case "1":
                        string subChoice1 = "";
                        while (subChoice1 != "10")
                        {
                            Console.Clear();
                            c1.ShowPlayerMenu();
                            Console.Write("Enter your choice: ");
                            subChoice1 = Console.ReadLine();
                            switch (subChoice1)
                            {
                                case "1":
                                    p.addnewplayer();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    p.RemovePlayer();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    p.Editplayer();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    p.showallplayer();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    p.namesearch();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.WriteLine("Option 1 > Sub-option 5");
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    p.playerfieldsearch();
                                    rw.savetofile1("Player.txt");
                                    Console.WriteLine("Option 1 > Sub-option 6");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    p.Mostgoalscorer();
                                    rw.savetofile1("Player.txt");
                                    Console.WriteLine("Option 1 > Sub-option 7");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    p.goalsearch();
                                    rw.savetofile1("Player.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    p.Randonselect();
                                    rw.savetofile1("Player.txt");
                                    Console.WriteLine("Option 1 > Sub-option 9");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case "2":
                        string subChoice2 = "";
                        while (subChoice2 != "10")
                        {
                            Console.Clear();
                            c1.ShowCouchMenu();
                            Console.Write("Enter your choice: ");
                            subChoice2 = Console.ReadLine();

                            switch (subChoice2)
                            {
                                case "1":
                                    couching.Insertcouch();
                                    wl.savetofile2("coach.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    couching.Editcouch();
                                    wl.savetofile2("coach.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    couching.NameCouchSearch();
                                    wl.savetofile2("coach.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    couching.Removecouch();
                                    wl.savetofile2("coach.txt");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    couching.showcouch();
                                    wl.savetofile2("coach.txt");
                                    Console.WriteLine("Option 2 > Sub-option 5");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.WriteLine("Option 2 > Sub-option 6");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("Option 2 > Sub-option 7");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    Console.WriteLine("Option 2 > Sub-option 8");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    Console.WriteLine("Option 2 > Sub-option 9");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case "3":

                        string subChoice3 = "";
                        while (subChoice3 != "10")
                        {
                            Console.Clear();
                            c1.ShowEmployeeMenu();
                            Console.Write("Enter your choice: ");
                            subChoice3 = Console.ReadLine();

                            switch (subChoice3)
                            {
                                case "1":
                                    e1.getemploy();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("Option 3 > Sub-option 2");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    e1.SearchEm();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.WriteLine("Option 3 > Sub-option 4");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    e1.showallemployee();
                                    Console.WriteLine("Option 3 > Sub-option 5");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    e1.TheSumSalaryOfEmployees();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("Option 3 > Sub-option 7");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    Console.WriteLine("Option 3 > Sub-option 8");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    Console.WriteLine("Option 3 > Sub-option 9");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case "4":
                        
                        string subChoic4 = "";
                        while (subChoic4 != "10" )
                        {
                            Console.Clear();
                            c1.ShowfinancialdepartmentMenu();
                            Console.Write("Enter your choice: ");
                            subChoic4 = Console.ReadLine();
                            switch (subChoic4)
                            {
                                case "1":
                                    fd.TheSumSalaryOfcouches();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    fd.TheSumSalaryOfcouches();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    fd.TheSumSalaryOfEmployees();
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.WriteLine("Option 2 > Sub-option 4");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.WriteLine("Option 2 > Sub-option 5");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.WriteLine("Option 2 > Sub-option 6");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("Option 2 > Sub-option 7");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    Console.WriteLine("Option 2 > Sub-option 8");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    Console.WriteLine("Option 2 > Sub-option 9");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    Console.Write("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                }
            }   
        }
    }
}
