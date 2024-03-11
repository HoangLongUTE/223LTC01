using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetEmployees();
            var departments = Department.GetDepartments();

            //Cau1
            Console.WriteLine("Cau 1: Hien thi max, min average salary: ");
            double maxSalary = employees.Max(e => e.Salary);
            double minSalary = employees.Min(e => e.Salary);
            double averageSalary = employees.Average(e => e.Salary);

            Console.WriteLine($"Max Salary: {maxSalary}");
            Console.WriteLine($"Min Salary: {minSalary}");
            Console.WriteLine($"Everage Salary: {averageSalary}");
            Console.WriteLine();

            //Cau2
            Console.WriteLine("Cau 2: Hien thi join group, left, right: ");
            // Group join
            var groupJoin = departments.GroupJoin(employees,
                            dept => dept.ID,
                            emp => emp.DepartmentID,
                            (dept, emps) => new
                            {
                                DepartmentName = dept.Name,
                                Employees = emps.Select(emp => new
                                {
                                    emp.Name,
                                    emp.ID,
                                    emp.Age,
                                    emp.Salary,
                                    Birthday = emp.Birthday.ToString("dd/MM/yyyy") // Định dạng ngày sinh theo định dạng bạn muốn
                                })
                            });

            Console.WriteLine("\nGroup Join:");
            foreach (var dept in groupJoin)
            {
                Console.WriteLine($"Department: {dept.DepartmentName}");
                foreach (var emp in dept.Employees)
                {
                    Console.WriteLine($"- Name: {emp.Name}, ID: {emp.ID}, Age: {emp.Age}, Salary: {emp.Salary}, Birthday: {emp.Birthday}");
                }
            }

            // Left join
            var leftJoin = from d in Department.GetDepartments()
                           join e in Employee.GetEmployees() on d.ID equals e.DepartmentID into deptEmps
                           from emp in deptEmps.DefaultIfEmpty()
                           select new
                           {
                               DepartmentID = d.ID,
                               DepartmentName = d.Name,
                               EmployeeName = emp != null ? emp.Name : "No Employee",
                               EmployeeAge = emp != null ? emp.Age : 0,
                              
                           };

            Console.WriteLine("\nLeft Join:");
            foreach (var item in leftJoin)
            {
                Console.WriteLine($"Department ID: {item.DepartmentID}, Department Name: {item.DepartmentName}, Employee Name: {item.EmployeeName}, Employee Age: {item.EmployeeAge}");
            }

            //Right join
            var rightJoin = from e in Employee.GetEmployees()
                            join d in Department.GetDepartments() on e.DepartmentID equals d.ID into empDepts
                            from dept in empDepts.DefaultIfEmpty()
                            select new
                            {
                                EmployeeName = e.Name,
                                EmployeeAge = e.Age,
                                // Thêm các thông tin khác của Employee nếu cần
                                DepartmentID = dept != null ? dept.ID : 0,
                                DepartmentName = dept != null ? dept.Name : "No Department"
                            };

            Console.WriteLine("\nRight Join:");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"Employee Name: {item.EmployeeName}, Employee Age: {item.EmployeeAge}, Department ID: {item.DepartmentID}, Department Name: {item.DepartmentName}");
            }
            Console.WriteLine();

            //Cau3
            Console.WriteLine("Cau 3: Hien thi nguoi lon, nho tuoi nhat: ");
            var today = DateTime.Today;
            var oldest = employees.OrderByDescending(e => (today - e.Birthday).TotalDays).First();
            var youngest = employees.OrderBy(e => (today - e.Birthday).TotalDays).First();

            Console.WriteLine($"Nguoi lon tuoi nhat: {oldest.Name}, Tuoi: {CalculateAge(oldest.Birthday)}");
            Console.WriteLine($"Nguoi nho tuoi nhat: {youngest.Name}, Tuoi: {CalculateAge(youngest.Birthday)}");

            Console.ReadKey();
        }

        static int CalculateAge(DateTime birthday)
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;
            if (birthday.Date > today.AddYears(-age)) age--;
            return age;
        }

        
        
    }
}
