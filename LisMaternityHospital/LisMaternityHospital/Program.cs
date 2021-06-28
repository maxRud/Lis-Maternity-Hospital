using LisMaternityHospital.Employees;
using LisMaternityHospital.Utils;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;



namespace LisMaternityHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            IList<IEmployee> employees = GenarateEmployees();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Start or End employees shift");
            Console.WriteLine("2) Show monthly salary");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    startOrEndShift(employees);
                    return true;
                case "2":
                    CalculateMonthlySalary(employees);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        public static void startOrEndShift(IList<IEmployee> employees)
        {
            int chosenEmployee;

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Start shift");
            Console.WriteLine("2) End shift");
            Console.WriteLine("3) Back to main menu");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    chosenEmployee = ChoseEmployee(employees);
                    StartShift(employees[chosenEmployee]);
                    ReturnToMenu();
                    return;
                case "2":
                    chosenEmployee = ChoseEmployee(employees);
                    EndShift(employees[chosenEmployee]);
                    ReturnToMenu();
                    return;
                case "3":
                    return;
                default:
                    return;
            }
        }
        public static void StartShift(IEmployee employee)
        {
            employee.StartShift();
            Console.WriteLine($"Shift of {employee.ToString()} have started");
        }
        public static void EndShift(IEmployee employee)
        {
            employee.EndShift();
            Console.WriteLine($"Shift of {employee.ToString()} has ended");
        }
        public static void CalculateMonthlySalary(IList<IEmployee> employees)
        {
            int chosenEmployee = ChoseEmployee(employees);
            double salary = employees[chosenEmployee].CalculateSalary();

            Console.WriteLine($"The salary of {chosenEmployee.ToString()} for this month is: {salary}");
            ReturnToMenu();
        }
        public static int ChoseEmployee(IList<IEmployee> employees)
        {
            Console.Clear();
            Console.WriteLine("Please choose employee: ");

            employees.ToList().Where(employee => !employee.CheckIfInShift());
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i}) {employees[i].ToString()}");
            }

            return Int32.Parse(CaptureInput(employees.Count));
        }
        private static string CaptureInput(int length)
        {
            while (true)
            {
                Console.Write("\r\nEnter the number of the employee you want to modify: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    if (int.TryParse(input, out _))
                    {
                        if (BetweenRanges(0, length, Int32.Parse(input)))
                        {
                            return input; //If the chosen value is not empty, int and between the range of the employees --> choose it
                        }
                    }
                }
            }
        }
        public static bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b); //Used to validate the input from the client.
        }
        private static void ReturnToMenu()
        {
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
        private static IList<IEmployee> GenarateEmployees()
        {
            IList<IEmployee> listOfEmployees = new List<IEmployee>();

            var time = DateTime.Now;
            Random randomHoursToAdd = new Random();

            listOfEmployees.Add(new AdministrativeEmployee("Donaold", "Trump", 1));
            listOfEmployees.Add(new BreechBirthIntern("Arnold", "Shvarz", 2));
            listOfEmployees.Add(new BreechBirthMidwife("Donaold", "Trump", 3));
            listOfEmployees.Add(new Chef("Donaold", "Trump", 4));
            listOfEmployees.Add(new Cleaner("Donaold", "Trump", 5));
            listOfEmployees.Add(new CleanerManager("Donaold", "Trump", 6));
            listOfEmployees.Add(new Cook("Donaold", "Trump", 7));
            listOfEmployees.Add(new DepartmentManager("Donaold", "Trump", 8));
            listOfEmployees.Add(new Doctor("Donaold", "Trump", 9));
            listOfEmployees.Add(new ExpertDoctor("Donaold", "Trump", 10));
            listOfEmployees.Add(new FoodDistrebuter("Donaold", "Trump", 11));
            listOfEmployees.Add(new HeadNurse("Donaold", "Trump", 12));
            listOfEmployees.Add(new Intern("Donaold", "Trump", 13));
            listOfEmployees.Add(new Medic("Donaold", "Trump", 14));
            listOfEmployees.Add(new Midwife("Donaold", "Trump", 15));
            listOfEmployees.Add(new Nurse("Donaold", "Trump", 16));
            listOfEmployees.Add(new Paramedic("Donaold", "Trump", 17));
            listOfEmployees.Add(new ProCleaner("Donaold", "Trump", 18));
            listOfEmployees.Add(new ProfessionalEmployee("Donaold", "Trump", 19));
            listOfEmployees.Add(new SeniorDoctor("Donaold", "Trump", 20));
            listOfEmployees.Add(new SuChef("Donaold", "Trump", 21));
            listOfEmployees.Add(new ToxicCleaner("Donaold", "Trump", 22));
            listOfEmployees.Add(new ViceDepartmentManager("Donaold", "Trump", 23));

            listOfEmployees.ToList().ForEach(employee =>
            {
                employee.StartShift(time);
                employee.EndShift(time.AddDays(randomHoursToAdd.Next(10, 80))); //Add random time to the shift
            });

            return listOfEmployees;
        }
    }
}
