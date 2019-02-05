using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public int salary;


        public Employee(string name, int id, string position, int salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public string CompareSalary(Employee employee)
        {
    

            if (salary > employee.salary)
            {
                return ($"Henkilön { name } palkka on suurempi kuin henkilön { employee.name } palkka.");
            }
            else if (salary < employee.salary)
            {
                return ($"Henkilön { employee.name } palkka on suurempi kuin henkilön { name } palkka.");
            }
            else
            {
                return ($"Henkilön { name } palkka on sama kuin henkilön { employee.name } palkka.");
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"\nTyöntekijän nimi: {name}" +
                $"\nTyöntekijän tunnus: {id}" +
                $"\nTyöntekijän titteli:{position}" +
                $"\nTyöntekijän palkka: {salary}€");
        }
    }
}