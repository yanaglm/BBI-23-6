using System;


//var 2
//1

struct Employee
{
    public string Name;
    public int Tabel_number;
    public int Age;
    public int StartYear;
    public double Salary;

    private static int workers_count_after2020 = 0;


    public Employee(string name, int tabel_number, int age, int startYear, double salary)
    {
        Name = name;
        Tabel_number = tabel_number;
        Age = age;
        StartYear = startYear;
        Salary = salary;

        if (StartYear > 2020)
        {
            workers_count_after2020++;
        }
    }
    public void PrintInfAboutWorker()
    {
        Console.WriteLine($"tabel number - {Tabel_number}, name - {Name}, age - {Age}, first year -  {StartYear}, salary: {Salary}");
    }

    public static void PrintIntAboutQauntityAfter2020()
    {
        Console.WriteLine($"workers after 2020: {workers_count_after2020}");
    }

}
/*
class Program
    {
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Employee("Adam Smith", 25001, 22, 2023, 3000),
            new Employee("Ben Williams", 25002, 46, 2017, 2500),
            new Employee("Roger Black", 25003, 31, 2021, 3500),
            new Employee("Mike Shelton ", 25004, 27, 2022, 2750),
            new Employee("Alex Johnson", 25005, 38, 2019, 3100)
        };


        for (int i = 0; i < employees.Length - 1; i++)
        {
            for (int j = 0; j < employees.Length - 1 - i; j++)
            {
                if (string.Compare(employees[j].Name.Split(' ')[1], employees[j + 1].Name.Split(' ')[1], StringComparison.Ordinal) > 0)
                {
                    var temp = employees[j];
                    employees[j] = employees[j + 1];
                    employees[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("workers inf");
        foreach (var employee in employees)
        {
            employee.PrintInfAboutWorker();
        }

        
        Employee.PrintIntAboutQauntityAfter2020();

    }
}
*/


//2
abstract class Company
{
    public string Name;
    public Employee[] Employees;

    public Company(string name, Employee[] employees)
    {
        Name = name;
        Employees = employees;
    }

    public double FindOutAverageSalary()
    {
        double final_salary = 0;
        foreach (var employee in Employees)
        {
            final_salary += employee.Salary;
        }
        return final_salary / Employees.Length;
    }
}

class ITCompany : Company
{
    public ITCompany(string name, Employee[] employees) : base(name, employees)
    {
    }
    
    public void HireByAge(int maxAge)
    {
        Console.WriteLine($"принятые на работу в {Name} из-за возраста (тк меньше максимального {maxAge} лет)");
        foreach (var employee in Employees)
        {
            if (employee.Age <= maxAge)
            {
                employee.PrintInfAboutWorker();
            }
        }
    }
}

class IndustrialCompany : Company
{
    public IndustrialCompany(string name, Employee[] employees) : base(name, employees)
    {
    }

    public void HireByExperience(int minYears)
    {
        Console.WriteLine($"принятые на работу в {Name} из-за стажа (тк больше минимального {minYears} лет)");
        foreach (var employee in Employees)
        {
            if (DateTime.Now.Year - employee.StartYear >= minYears)
            {
                employee.PrintInfAboutWorker();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] IT_employees = new Employee[]
        {
            new Employee("Adam Smith", 25001, 22, 2023, 3000),
            new Employee("Ben Williams", 25002, 46, 2017, 2500),
            new Employee("Roger Black", 25003, 31, 2021, 3500),
            new Employee("Mike Shelton ", 25004, 27, 2022, 2750),
            new Employee("Alex Johnson", 25005, 38, 2019, 3100)
        };

        Employee[] Industrial_Employees = new Employee[]
        {
            new Employee("Ginny Smith", 26001, 21, 2022, 2500),
            new Employee("Julia Williams", 26002, 46, 2018, 3500),
            new Employee("Emily Black", 26003, 28, 2023, 3250),
            new Employee("Jenny Shelton", 26004, 24, 2019, 2000),
            new Employee("Selena Johnson", 26005, 35, 2021, 2750)
        };

        ITCompany[] IT_Companies = new ITCompany[]
        {
            new ITCompany("Apple", IT_employees),
            new ITCompany("Google", IT_employees),
            new ITCompany("Yandex", IT_employees),
            new ITCompany("VK", IT_employees),
            new ITCompany("Microsoft", IT_employees)
        };

        IndustrialCompany[] industrial_Companies = new IndustrialCompany[]
        {
            new IndustrialCompany("Abc", Industrial_Employees),
            new IndustrialCompany("Tesla", Industrial_Employees),
            new IndustrialCompany("BMW", Industrial_Employees),
            new IndustrialCompany("Micro company", Industrial_Employees),
            new IndustrialCompany("Ingineering company", Industrial_Employees)
        };

        for (int i = 0; i < IT_Companies.Length - 1; i++)
        {
            for (int j = 0; j < IT_Companies.Length - 1 - i; j++)
            {
                if (IT_Companies[j].FindOutAverageSalary() < IT_Companies[j + 1].FindOutAverageSalary())
                {
                    var x = IT_Companies[j];
                    IT_Companies[j] = IT_Companies[j + 1];
                    IT_Companies[j + 1] = x;
                }
            }
        }



        Console.WriteLine("IT companies Inf");
        foreach (var company in IT_Companies)
        {
            Console.WriteLine($"company: {company.Name}, average salary: {company.FindOutAverageSalary()}");
        }


        for (int i = 0; i < industrial_Companies.Length - 1; i++)
        {
            for (int j = 0; j < industrial_Companies.Length - 1 - i; j++)
            {
                if (industrial_Companies[j].FindOutAverageSalary() < industrial_Companies[j + 1].FindOutAverageSalary())
                {
                    var x = industrial_Companies[j];
                    industrial_Companies[j] = industrial_Companies[j + 1];
                    industrial_Companies[j + 1] = x;
                }
            }
        }

        Console.WriteLine("industrial companies Inf");
        foreach (var company in industrial_Companies)
        {
            Console.WriteLine($"company: {company.Name}, average salary: {company.FindOutAverageSalary()}");
        }

        Company[] all_companies = new Company[IT_Companies.Length + industrial_Companies.Length];
        Array.Copy(IT_Companies, 0, all_companies, 0, IT_Companies.Length);
        Array.Copy(industrial_Companies, 0, all_companies, IT_Companies.Length, industrial_Companies.Length);

        for (int i = 0; i < all_companies.Length - 1; i++)
        {
            for (int j = 0; j < all_companies.Length - 1 - i; j++)
            {
                if (all_companies[j].FindOutAverageSalary() < all_companies[j + 1].FindOutAverageSalary())
                {
                    var x = all_companies[j];
                    all_companies[j] = all_companies[j + 1];
                    all_companies[j + 1] = x;
                }
            }
        }

        Console.WriteLine("all companies Inf");
        foreach (var company in all_companies)
        {
            Console.WriteLine($"company: {company.Name}, average salary: {company.FindOutAverageSalary()}");
        }
    }
}