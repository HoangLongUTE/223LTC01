using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT3
{
    class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int DepartmentID { set; get; }
        public int Age { set; get; }
        public double Salary { set; get; }
        public DateTime Birthday { set; get; }

        public static List<Employee> GetEmployees() {
            return new List<Employee>()
            {
                new Employee{ ID=1, Name="A", DepartmentID=1, Age=20, Salary=20000000, Birthday=new DateTime(2000, 10, 20)},
                new Employee{ ID=2, Name="B", DepartmentID=2, Age=21, Salary=17000000, Birthday=new DateTime(2000, 02, 20)},
                new Employee{ ID=3, Name="C", DepartmentID=3, Age=19, Salary=25000000, Birthday=new DateTime(1999, 10, 24)},
                new Employee{ ID=4, Name="D", DepartmentID=1, Age=25, Salary=20000000, Birthday=new DateTime(1997, 07, 03)},
                new Employee{ ID=5, Name="E", DepartmentID=2, Age=31, Salary=37000000, Birthday=new DateTime(1998, 05, 15)},
            };
        }
    }
}
