using System;
using System.IO;

namespace End_of_the_fotball_project
{
    internal class club
    {
        public string[] Playername = new string[100];
        protected string[] Playerfield = new string[100];
        protected int[] PlayerGoals = new int[100];
        protected int[] PlayerAges = new int[100];
        public int[] PlayerSalary = new int[100];
        public int[] CouchSalary = new int[100];
        public int[] employeeSalary = new int[100];
        protected int curIndex = 0;
        protected int rndNumber;
        protected string[] couchingstaff = new string[100];
    }
    class players : club
    {
        public void addnewplayer()
        {
            Console.Clear();
            Console.WriteLine("\nInserting a new Player : ");
            Console.Write("name: ");
            Playername[curIndex] = Console.ReadLine();
            Console.Write("field: ");
            Playerfield[curIndex] = Console.ReadLine();
            Console.Write("age: ");
            PlayerAges[curIndex] = int.Parse(Console.ReadLine());
            Console.Write("goals: ");
            PlayerGoals[curIndex] = int.Parse(Console.ReadLine());
            Console.Write("salary : ");
            PlayerSalary[curIndex] = int.Parse(Console.ReadLine());
            curIndex++;
            Console.WriteLine("curindex"+ curIndex);
        }
        public void showallplayer()
        {
            Console.Clear();
            for (int i = 0; i < curIndex; i++)
            {
                Console.WriteLine($"Player : {i+1}");
                Console.WriteLine("\tname:" + Playername[i] +
                    "\t\tfield : " + Playerfield[i] +
                    "\tage : " + PlayerAges[i] +
                    "\tgoals : " + PlayerGoals[i] +
                    "\tsalary " + PlayerSalary[i]
                    );
            }
        }

        public void RemovePlayer()
        {
            Console.Clear();
            showallplayer();
            Console.Write("name : ");
            string a = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (Playername[i] == a)
                {
                    Playername[i] = null;
                    Playerfield[i] = null;
                    PlayerAges[i] = 0;
                    PlayerGoals[i] = 0;
                    PlayerSalary[i] = 0;
                    couchingstaff[i] = null;
                    for (int j = i; j < curIndex; j++)
                    {
                        Playername[j] = Playername[j + 1];
                        Playerfield[j] = Playerfield[j + 1];
                        PlayerAges[j] = PlayerAges[j + 1];
                        PlayerGoals[i] = PlayerGoals[j + 1];
                        PlayerSalary[i] = PlayerSalary[j + 1];
                        couchingstaff[i] = couchingstaff[j + 1];
                    }
                    Playername[curIndex] = null;
                    Playerfield[curIndex] = null;
                    PlayerAges[curIndex] = 0;
                    PlayerGoals[curIndex] = 0;
                    PlayerSalary[curIndex] = 0;
                    couchingstaff[curIndex] = null;
                    curIndex--;
                }
                else continue;
            }
            Console.WriteLine("the player was removed:");
            Console.WriteLine("press key to continue...");
            Console.ReadKey();
        }

        public virtual void Editplayer()
        {
            Console.Clear();
            showallplayer();
            Console.WriteLine("choise name : ");
            string name = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (Playername[i] == name)
                {
                    Console.WriteLine("name : ");
                    Playername[i] = Console.ReadLine();
                    Console.WriteLine("field : ");
                    Playerfield[i] = Console.ReadLine();
                    Console.WriteLine("age : ");
                    PlayerAges[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("goals : ");
                    PlayerGoals[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public virtual void namesearch()
        {
            Console.Clear();
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (Playername[i] == name)
                {
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "\tsalary : " + PlayerSalary[i]);
                }
            }
            Console.WriteLine("press key to continue...");
        }

        public virtual void playerfieldsearch()
        {
            Console.Clear();
            Console.WriteLine("Enter playerfield : ");
            string field = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (Playerfield[i] == field)
                {
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "\tsalary : " + PlayerSalary[i]);
                }
            }
            Console.WriteLine("press key to continue : ");
        }

        public void capitanchoice()
        {
            Console.Clear();
            int max = PlayerAges[0];
            for (int i = 0; i < curIndex; i++)
            {
                if (PlayerAges[i] > max)
                {
                    max = PlayerAges[i];
                    Console.WriteLine("capitan : ");
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "amount : " + PlayerSalary[i]);
                }
            }
            Console.WriteLine("press any key to continue...");
        }


        public virtual void Randonselect()
        {
            Console.Clear();
            Random r1 = new Random();
            rndNumber = r1.Next(curIndex);
            Console.WriteLine(
                        "\tname : " + Playername[rndNumber] +
                        "\tfield : " + Playerfield[rndNumber] +
                        "\tage : " + PlayerAges[rndNumber] +
                        "\tgoals : " + PlayerGoals[rndNumber] +
                        "\tsalary : " + PlayerSalary[rndNumber]);
            Console.WriteLine("press any key to continue...");
        }

        public void salarysearch()
        {
            Console.Clear();
            Console.WriteLine("Eror Amount : ");
            int Amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < curIndex; i++)
            {
                if (PlayerSalary[i] == Amount)
                {
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "amount : " + PlayerSalary[i]);
                }
                else { Console.WriteLine("user not found."); }
            }
            Console.WriteLine("press any key to continue ...");
        }

        public virtual void goalsearch()
        {
            Console.Clear();
            Console.WriteLine("Enter goals : ");
            int goals = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < curIndex; i++)
            {
                if (PlayerGoals[i] == goals)
                {
                    Console.WriteLine("user found.");
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "\tsalary : " + PlayerSalary[i]);
                }
                else { Console.WriteLine("user not found."); }
            }
        }

        public void agesearch()
        {
            Console.Clear();
            Console.WriteLine("Enter age :");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < curIndex; i++)
            {
                if (PlayerAges[i] == age)
                {
                    Console.WriteLine(
                        "\tname : " + Playername[i] +
                        "\tfield : " + Playerfield[i] +
                        "\tage : " + PlayerAges[i] +
                        "\tgoals : " + PlayerGoals[i] +
                        "\tsalary : " + PlayerSalary[i]);
                }
            }
        }

        public void Mostgoalscorer()
        {
            Console.Clear();
            int max = PlayerGoals[0];
            for (int i = 1; i < curIndex; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (PlayerGoals[i] > max)
                    {
                        max = PlayerGoals[i];

                        Console.WriteLine(
                            "\tname : " + Playername[i] +
                            "\tfield : " + Playerfield[i] +
                            "\tage : " + PlayerAges[i] +
                            "\tgoals : " + PlayerGoals[i] +
                            "\tsalary : " + PlayerSalary[i]);
                    }
                }
                Console.WriteLine();
            }

        }

    }

    class Readsndwrite1 : players
    {
        public void savetofile1(string path)
        {
            Console.WriteLine(curIndex);
            try
            {
                StreamWriter writer = new StreamWriter(path , true);
                writer.WriteLine("name : " + Playername[curIndex]);
                writer.WriteLine("playerfield : " + Playerfield[curIndex]);
                writer.WriteLine("player age : " + PlayerAges[curIndex]);
                writer.WriteLine("player goals : " + PlayerGoals[curIndex]);
                writer.WriteLine("TeamCadre : " + couchingstaff[curIndex]);
                writer.Flush();
                writer.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in writing to file1...");
                Console.WriteLine("Error Message: " + e.Message);
            }
        }
        public void loadfromfile1(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                while (reader.Peek() != -1)
                {
                    string st = reader.ReadLine();
                    string[] param = st.Split(',');
                    int[] ints = new int[param.Length];
                    Playername[curIndex] = param[0];
                    Playerfield[curIndex] = param[1];
                    PlayerAges[curIndex] = ints[2];
                    PlayerGoals[curIndex] = int.Parse(param[3]);
                    curIndex++;
                }
                reader.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in reading file: " + path);
            }
        }
    }

    class Couching : club
    {
        protected string[] ncoucher = new string[100];
        protected int[] agecouch = new int[100];
        public void Insertcouch()
        {
            Console.Clear();
            Console.WriteLine("\nInserting a new couch : ");
            Console.Write("name: ");
            ncoucher[curIndex] = Console.ReadLine();
            Console.Write("age: ");
            agecouch[curIndex] = int.Parse(Console.ReadLine());
            Console.Write("salary: ");
            CouchSalary[curIndex] = int.Parse(Console.ReadLine());
            curIndex++;
            
        }

        public void Editcouch()
        {
            Console.Clear();
            showcouch();
            Console.WriteLine("choose name : ");
            string name = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (ncoucher[i] == name)
                {
                    Console.Write("name : ");
                    ncoucher[i] = Console.ReadLine();
                    Console.Write("age : ");
                    agecouch[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("salary : ");
                    CouchSalary[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public virtual void NameCouchSearch()
        {
            Console.Clear();
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (ncoucher[i] == name)
                {
                    Console.WriteLine(
                        "\tname : " + ncoucher[i] +
                        "\tage : " + agecouch[i] +
                        "\tsalary : " + CouchSalary[i]);
                }
            }
        }
        public void Removecouch()
        {
            Console.Clear();
            showcouch();
            Console.Write("name : ");
            string a = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (ncoucher[i] == a)
                {
                    ncoucher[i] = null;
                    agecouch[i] = 0;
                    CouchSalary[i] = 0;
                    for (int j = i; j < curIndex; j++)
                    {
                        ncoucher[j] = ncoucher[j + 1];
                        agecouch[j] = agecouch[j + 1];
                        CouchSalary[i] = CouchSalary[j + 1];
                    }
                    ncoucher[curIndex] = null;
                    agecouch[curIndex] = 0;
                    CouchSalary[curIndex] = 0;
                    curIndex--;
                    Console.WriteLine("the player was removed.");
                }
                else continue;
            }
            Console.ReadKey();
        }
        public void showcouch()
        {
            Console.Clear();
            for (int i = 0; i < curIndex; i++)
            {
                Console.WriteLine($"couch : {i + 1}");
                Console.WriteLine("\tname:" + ncoucher[i] +
                    "\tage : " + agecouch[i] +
                    "\tsalary " + CouchSalary[i]
                    );
            }
        }
    }

    abstract class Readandwrite2 : Couching
    {
        public abstract void savetofile2(string path1);
        public abstract void loadfromfile2(string path1);
    }

    sealed class WritingandLoading : Readandwrite2
    {
        public override void loadfromfile2(string path1)
        {

            try
            {
                StreamReader reader = new StreamReader(path1);
                while (reader.Peek() != -1)
                {
                    string st = reader.ReadLine();
                    string[] param = st.Split(',');
                    int[] ints = new int[param.Length];
                    ncoucher[curIndex] = param[0];
                    CouchSalary[curIndex] = int.Parse(param[1]);
                }
                reader.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in reading file: " + path1);
            }
        }

        public override void savetofile2(string path2)
        {
            
            try
            {
                StreamWriter writer = new StreamWriter(path2);
                writer.WriteLine(  ncoucher + "," + agecouch +"," + CouchSalary); 
                writer.Flush();
                writer.Close();
            }

            catch (Exception e1)
            {
                Console.WriteLine("Error in writing to file2...");
                Console.WriteLine("Error Message: " + e1.Message);
            }
        }
    }
    abstract class employee : club
    {
        public abstract void getemploy();
    }

    interface IEx
    {
        void SearchEm();
    }
    interface IHW
    {
        void TheSumSalaryOfEmployees();
    }

    class employee1 : employee, IEx, IHW
    {
        private int[] employeeage = new int[100];
        private string[] employeename = new string[100];
        public override void getemploy()
        {
            Console.Clear();
            Console.WriteLine("\nInserting a new Employee ");
            Console.Write("name: ");
            employeename[curIndex] = Console.ReadLine();
            Console.Write("age: ");
            employeeage[curIndex] = int.Parse(Console.ReadLine());
            Console.Write("salary: ");
            employeeSalary[curIndex] = int.Parse(Console.ReadLine());
            curIndex++;
        }

        public void SearchEm()
        {
            Console.Clear();
            Console.WriteLine("Enter couching staff : ");
            string NameEm = Console.ReadLine();
            for (int i = 0; i < curIndex; i++)
            {
                if (employeename[i] == NameEm)
                {
                    Console.WriteLine(
                            "\tname : " + employeename[i] +
                            "\tage : " + employeeage[i] +
                            "\tsalary : " + employeeSalary[i]);
                    Console.WriteLine("Expert Employee.");
                }
            }
        }

        public void TheSumSalaryOfEmployees()
        {
            int sum = 0;
            for (int i = 0; i< employeeSalary.Length; i++)
            {
                sum += employeeSalary[i];
            }
        }

        public void showallemployee()
        {
            Console.Clear();
            for (int i = 0; i < curIndex; i++)
            {
                Console.WriteLine($"Emplyee : {i + 1}");
                Console.WriteLine(
                    "\tname:" + employeename[i] +
                    "\tage : " + employeeage[i] +
                    "\tsalary " + employeeSalary[i]
                    );
            }
        }
    }
    class allclub
    {

    }
}
