using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <Car>
            List<Car> cars = new List<Car>
            {
                new Car { Make = "Toyota", Model = "Camry", Year = "2005", Price = 150000, Color = "Black", Seats = 5, LicensePlate = "ABC123", Mileage = "50000" },
                new Car { Make = "Honda", Model = "Civic", Year = "1998", Price = 80000, Color = "Blue", Seats = 5, LicensePlate = "XYZ456", Mileage = "80000" },
                new Car { Make = "Ford", Model = "Focus", Year = "2010", Price = 200000, Color = "Red", Seats = 5, LicensePlate = "DEF789", Mileage = "30000" },
                new Car { Make = "Nissan", Model = "Altima", Year = "1995", Price = 50000, Color = "Silver", Seats = 5, LicensePlate = "GHI101", Mileage = "120000" },
                new Car { Make = "Toyota", Model = "Corolla", Year = "2015", Price = 180000, Color = "Black", Seats = 5, LicensePlate = "JKL321", Mileage = "40000" },
                new Car { Make = "Honda", Model = "Accord", Year = "2012", Price = 220000, Color = "Blue", Seats = 5, LicensePlate = "MNO654", Mileage = "60000" },
                new Car { Make = "Ford", Model = "Mustang", Year = "2020", Price = 300000, Color = "Red", Seats = 5, LicensePlate = "PQR987", Mileage = "20000" },
                new Car { Make = "Nissan", Model = "Maxima", Year = "2018", Price = 180000, Color = "Silver", Seats = 5, LicensePlate = "STU210", Mileage = "30000" }

            };
            // 2a.
            var carsInRange = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("2a. Cac xe co gia tu 100,000 den 250,000:");
            foreach (var car in carsInRange)
            {
                Console.WriteLine($"{car.Make} {car.Model} - ${car.Price}");
            }
            Console.WriteLine();

            // 2b. 
            var carsAfter1990 = cars.Where(car => int.Parse(car.Year) > 1990);
            Console.WriteLine("2b. Xe co nam san xuat sau 1990:");
            foreach (var car in carsAfter1990)
            {
                Console.WriteLine($"{car.Make} {car.Model} - {car.Year}");
            }
            Console.WriteLine();

            // 2c.
            var groupedCars = cars.GroupBy(car => car.Make).Select(group => new
            {
                Make = group.Key,
                TotalPrice = group.Sum(car => car.Price)
            });
            Console.WriteLine("2c. Tong gia tri cua cac hang xe:");
            foreach (var group in groupedCars)
            {
                Console.WriteLine($"{group.Make}: ${group.TotalPrice}");
            }
            Console.WriteLine();

            //List <Truck>
            List<Truck> trucks = new List<Truck>
            {
                new Truck { Make = "Volvo", Model = "FH16", Year = "2018", Price = 300000, Company = "ABC Logistics", Load = "10 tons", Cargo = "Construction materials", Fuel = "Diesel" },
                new Truck { Make = "Mercedes-Benz", Model = "Actros", Year = "2016", Price = 280000, Company = "XYZ Transport", Load = "8 tons", Cargo = "Goods delivery", Fuel = "Diesel" },
                new Truck { Make = "Scania", Model = "R580", Year = "2019", Price = 320000, Company = "DEF Haulage", Load = "12 tons", Cargo = "Food products", Fuel = "Diesel" },
                new Truck { Make = "MAN", Model = "TGX", Year = "2015", Price = 260000, Company = "GHI Logistics", Load = "7 tons", Cargo = "Bulk materials", Fuel = "Diesel" },
                new Truck { Make = "Ford", Model = "F150", Year = "2017", Price = 270000, Company = "JKL Freight", Load = "6 tons", Cargo = "Automobile parts", Fuel = "Gasoline" },
                new Truck { Make = "Isuzu", Model = "NQR", Year = "2014", Price = 240000, Company = "MNO Transport", Load = "5 tons", Cargo = "Electronics", Fuel = "Diesel" },
                new Truck { Make = "Hino", Model = "338", Year = "2013", Price = 230000, Company = "PQR Logistics", Load = "4 tons", Cargo = "Pharmaceuticals", Fuel = "Diesel" },
                new Truck { Make = "Kenworth", Model = "T680", Year = "2020", Price = 350000, Company = "STU Haulage", Load = "11 tons", Cargo = "Livestock", Fuel = "Diesel" }
            };
            // 3a. 
            var trucksOrderedByYear = trucks.OrderByDescending(truck => int.Parse(truck.Year));
            Console.WriteLine("3a. Truck theo nam moi nhat:");
            foreach (var truck in trucksOrderedByYear)
            {
                Console.WriteLine($"{truck.Make} {truck.Model} - {truck.Year}");
            }
            Console.WriteLine();

            // 3b. 
            var truckCompanies = trucks.Select(truck => truck.Company);
            Console.WriteLine("3b. Cong chu quan");
            foreach (var company in truckCompanies)
            {
                Console.WriteLine(company);
            }

            Console.ReadKey();
        }
    }
}
