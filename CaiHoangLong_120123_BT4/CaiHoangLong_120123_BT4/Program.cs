using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT4
{
    class Program
    {
        class Department
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Department(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }
        class Position
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public Department Department { get; set; }

            public Position(string title, string description, Department department)
            {
                Title = title;
                Description = description;
                Department = department;
            }
        }
        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public Position Position { get; set; }

            public Employee(string name, int age, string gender, string email, Position position)
            {
                Name = name;
                Age = age;
                Gender = gender;
                Email = email;
                Position = position;
            }
        }
        static void Main(string[] args)
        {
            var departments = new List<Department>
            {
            new Department("Phong ke toan", "Phong chiu trach nhiem ve tai chinh va ke toan"),
            new Department("Phong nhan su", "Phong quan ly ve nhan su va tai nguyen con nguoi"),
            new Department("Phong san xuat", "Phong chiu trach nhiem ve qua trinh san xuat"),
            };

            var positions = new List<Position>
            {
            new Position("Ke toan vien", "Chiu trach nhiem ve cong viec ke toan", departments[0]),
            new Position("Nhan vien tuyen dung", "Chiu trach nhiem ve viec tuyen dung va quan ly nhan su", departments[1]),
            new Position("Quan doc san xuat", "Chiu trach nhiem quan ly qua trinh san xuat", departments[2]),
            new Position("Nhan vien sale", "Chiu trach nhiem thuc hien hoat dong ban hang", departments[1]),
            new Position("Ky su san xuat", "Chiu trach nhiem thiet ke va quan ly du an san xuat", departments[2]),
            new Position("Thu ky", "Chiu trach nhiem ho tro cong viec van phong", departments[0])
            };
            var employees = new List<Employee>
            {
            new Employee("Hoang Van Thai", 30, "Nam", "hvt@gmail.com", positions[0]),
            new Employee("Nguyen Thi Lan", 25, "Nu", "ntl@gmail.com", positions[1]),
            new Employee("Tran Minh Tuan", 35, "Nam", "tmt@gmail.com", positions[2]),
            new Employee("Le Thi Hong", 28, "Nu", "lth@gmail.com", positions[3]),
            new Employee("Pham Van Duc", 40, "Nam", "pvd@gmail.com", positions[4]),
            new Employee("Nguyen Thi Mai", 32, "Nu", "ntm@gmail.com", positions[5]),
            new Employee("Vu Van Hai", 22, "Nam", "vvh@gmail.com", positions[0]),
            new Employee("Tran Thi Huong", 38, "Nu", "tth@gmail.com", positions[1]),
            new Employee("Nguyen Van Nam", 27, "Nam", "nvn@gmail.com", positions[2]),
            new Employee("Le Thi Thao", 33, "Nu", "ltt@gmail.com", positions[3]),
            new Employee("Ho Thi Anh", 31, "Nu", "hta@gmail.com", positions[0]),
            new Employee("Tran Thi Bich", 29, "Nu", "ttb@gmail.com", positions[1]),
            new Employee("Nguyen Thi Cam", 36, "Nu", "ntc@gmail.com", positions[2]),
            new Employee("Do Thi Dung", 24, "Nu", "dtd@gmail.com", positions[3]),
            new Employee("Pham Thi Hanh", 39, "Nu", "pth@gmail.com", positions[4]),
            new Employee("Trinh Thi Khanh", 26, "Nu", "ttk@gmail.com", positions[5]),
            new Employee("Le Thi Lien", 34, "Nu", "ltl@gmail.com", positions[0]),
            new Employee("Nguyen Thi My", 23, "Nu", "ntm2@gmail.com", positions[1]),
            new Employee("Tran Thi Ngoc", 37, "Nu", "ttn@gmail.com", positions[2]),
            new Employee("Phan Thi Phuong", 28, "Nu", "ptp@gmail.com", positions[3])
            };
            while (true)
            {
                Console.WriteLine("Nhap tu khoa tim kiem (nhap Enter de bo qua):");
                string keyword = Console.ReadLine().ToLower();

                Console.WriteLine("Nhap tuoi tu (nhap Enter de bo qua):");
                int minAge;
                bool validMinAge = int.TryParse(Console.ReadLine(), out minAge);

                Console.WriteLine("Nhap tuoi den (nhap Enter de bo qua):");
                int maxAge;
                bool validMaxAge = int.TryParse(Console.ReadLine(), out maxAge);

                Console.WriteLine("Nhap vi tri (nhap Enter de bo qua):");
                string position = Console.ReadLine().ToLower();

                Console.WriteLine("Nhap phong ban (nhap Enter de bo qua):");
                string department = Console.ReadLine().ToLower();

                var results = employees.Where(emp =>
                    (string.IsNullOrWhiteSpace(keyword) || emp.Name.ToLower().Contains(keyword) || emp.Position.Title.ToLower().Contains(keyword) || emp.Position.Department.Name.ToLower().Contains(keyword))
                    && (!validMinAge || emp.Age >= minAge)
                    && (!validMaxAge || emp.Age <= maxAge)
                    && (string.IsNullOrWhiteSpace(position) || emp.Position.Title.ToLower().Contains(position))
                    && (string.IsNullOrWhiteSpace(department) || emp.Position.Department.Name.ToLower().Contains(department))
                );

                Console.WriteLine("\nKet qua tim kiem:");
                foreach (var result in results)
                {
                    Console.WriteLine($"Ten: {result.Name}, Tuoi: {result.Age}, Vi tri: {result.Position.Title}, Phong ban: {result.Position.Department.Name}");
                }
                Console.WriteLine("\nNhan Enter de tiep tuc:");
                Console.ReadLine();
            }
        }
    }
}
