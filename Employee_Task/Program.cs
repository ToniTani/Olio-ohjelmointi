using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Matti Meikäläinen", 15236, "Toimitusjohtaja", 17000);
            employees[1] = new Employee("Jutta Jussila", 78758, "Myyntipäällikkö", 4304);
            employees[2] = new Employee("Jamo Paholainen", 666999, "Kokki", 3000);
            employees[3] = new Employee("Jimo Tutila", 1995, "Maailmanmestari", 17000);

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            employees[0].CompareSalary(employees[3]);
            employees[1].CompareSalary(employees[2]);
            employees[2].CompareSalary(employees[3]);
            employees[3].CompareSalary(employees[0]);
            


            employees[0].PrintEmployeeInfo();
            employees[1].PrintEmployeeInfo();
            employees[2].PrintEmployeeInfo();
            employees[3].PrintEmployeeInfo();
            Console.WriteLine();



            Console.WriteLine(employees[0].CompareSalary(employees[1]));
            Console.WriteLine(employees[1].CompareSalary(employees[2]));
            Console.WriteLine(employees[2].CompareSalary(employees[3]));
            Console.WriteLine(employees[3].CompareSalary(employees[0]));

            Console.ReadKey();
        }
    }
}

