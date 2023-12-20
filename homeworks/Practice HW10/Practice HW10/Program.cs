namespace Company
{
    internal class Program
    {
        public record Employee // класс представляющий сотрудника
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; } // занимаемая должность
            public decimal Salary { get; set; } // зарплата
        }

        public class Department // класс представляющий отдел в компании
        {
            public string DepartmentName { get; set; } // название отдела
            public Employee[] employee { get; set; } // список сотрудников работающих в этой компании
        }

        public class Company // класс представляющий саму компанию
        {
            public string CompanyName { get; set; }
            public Department[] Departmentlist { get; set; } // списки отделов
            public string CompanyDescription { get; set; }
        }

        public static void DisplayInfo()
        {
            Employee employee1 = new()
            {
                FirstName = "Баходур",
                LastName = "Турсунов",
                Position = "Backend developer",
                Salary = 10000
            };

            Employee employee2 = new()
            {
                FirstName = "Ислам",
                LastName = "Исмаилов",
                Position = "Full stack developer",
                Salary = 20000
            };

            Employee[] employees =
            {
                employee1,
                employee2
            };

            Department department1 = new()
            {
                DepartmentName = "IT",
                employee = employees
            };

            Department[] departments =
            {
                department1
            };

            Company FirstCompany = new()
            {
                CompanyName = "Alif",
                Departmentlist = departments,
                CompanyDescription = "Алиф Бонк, англ. Alif Bank; ранее — Алиф Капитал, Алиф Сармоя) — финансово-технологическая компания, основанная в 2014 году и преобразованная в банк в 2020 году. Алиф использует принципы исламского финансирования. Офисы расположены в Душанбе и Худжанде."
            };

            Company SecondCompany = new()
            {
                CompanyName = "Eskhata",
                Departmentlist = departments,
                CompanyDescription = "Банк Эсхата — таджикский коммерческий банк, один из крупнейших коммерческих Банков Таджикистана, который входит в пятерку лидеров в банковской сфере страны. Полное наименование — Открытое акционерное общество «Банк Эсхата». Кроме того, в деловой практике зачастую используется сокращение"
            };

            Console.WriteLine($"Company: {FirstCompany.CompanyName}");
            foreach (var department in FirstCompany.Departmentlist)
            {
                Console.WriteLine($"  Department: {department1.DepartmentName}");
                foreach (var employee in department1.employee)
                {
                    Console.WriteLine($"    Employee: {employee.FirstName} {employee.LastName}, {employee.Position}, Salary: {employee.Salary}$");
                }
            }
            Console.WriteLine($"Company: {SecondCompany.CompanyName}");
            foreach (var department in FirstCompany.Departmentlist)
            {
                Console.WriteLine($"  Department: {department1.DepartmentName}");
                foreach (var employee in department1.employee)
                {
                    Console.WriteLine($"    Employee: {employee.FirstName} {employee.LastName}, {employee.Position}, Salary: {employee.Salary}$");
                }
            }
        }
        static void Main(string[] args)
        {
            DisplayInfo();
        }
    }
}

