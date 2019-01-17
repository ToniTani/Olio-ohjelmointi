using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public int Salary;


        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public string CompareSalary(Employee employee)
        {
    

            if (Salary > employee.Salary)
            {
                return ($"Henkilön { Name } palkka on suurempi kuin henkilön { employee.Name } palkka.");
            }
            else if (Salary < employee.Salary)
            {
                return ($"Henkilön { employee.Name } palkka on suurempi kuin henkilön { Name } palkka.");
            }
            else
            {
                return ($"Henkilön { Name } palkka on sama kuin henkilön { employee.Name } palkka.");
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"\nTyöntekijän nimi: {Name}" +
                $"\nTyöntekijän tunnus: {Id}" +
                $"\nTyöntekijän titteli:{Position}" +
                $"\nTyöntekijän palkka: {Salary}€");
        }
    }
}