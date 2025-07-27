using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_of_the_fotball_project
{
    interface ITS
    {
        void TheSumSalaryOfPlayers();
        void TheSumSalaryOfcouches();
        void TheSumSalaryOfEmployees();
    }
    abstract class noimplemented
    {
        public abstract void notimplemented1();
    }
    internal class financial_department : club,ITS
    {
        public void TheSumSalaryOfcouches()
        {
            int sum = 0;
            for (int i = 0; i < CouchSalary.Length; i++)
            {
                sum += CouchSalary[i];
            }
            Console.WriteLine(sum);
        }

        public void TheSumSalaryOfEmployees()
        {

            int sum = 0;
            for (int i = 0; i < employeeSalary.Length; i++)
            {
                sum += employeeSalary[i];
            }
            Console.WriteLine(sum);
        }

        public void TheSumSalaryOfPlayers()
        {
            int sum = 0;
            for (int i = 0; i < PlayerSalary.Length; i++)
            {
                sum += PlayerSalary[i];
            }
            Console.WriteLine(sum);
        }
    } 
}
