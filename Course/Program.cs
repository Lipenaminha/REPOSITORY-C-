using System;
using System.Globalization;
using C_.Entities.Enums;
using C_.Entities;

namespace Course
{
    class Course
    {


        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string departmentname = Console.ReadLine();
            Console.WriteLine("Enter worker data ");
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary : ", CultureInfo.InvariantCulture);
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Departament dept = new Departament(departmentname);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.WriteLine();
            Console.WriteLine("How many contracts to the work ? : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Enter #{i} contract data ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour : ");
                double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours) : ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hour);
                worker.AddContract(contract);


            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2));
            int year = int.Parse(monthandyear.Substring(3));
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthandyear + " : " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();



        }

    }

}



