using LisMaternityHospital.Employees;
using LisMaternityHospital.Utils;
using System;

namespace LisMaternityHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var time = DateTime.Now;
            HeadMaster a = new HeadMaster("Donaold", "Trump");
            a.StartShift(time);
            a.EndShift(time.AddHours(10));
            Console.WriteLine(a.CalculateSalary());
            
        }
    }
}
