using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocketFreight.Models;

namespace RocketFreight.Data
{
    public class DataSeeder
    {
        public List<Trip> SeedTrips()
        {
            var trips = new List<Trip>
        {
            new Trip
            {
                Id = Guid.NewGuid(),
                Name = "Trip 1",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(3),
                Destination = "Destination A",
                Orders = new List<Order>
                {
                    new Order { Id = Guid.NewGuid(), Customer_Id = Guid.NewGuid(), Details = "Details A", OrderTime = DateTime.Now },
                    new Order { Id = Guid.NewGuid(), Customer_Id = Guid.NewGuid(), Details = "Details B", OrderTime = DateTime.Now.AddMinutes(30) }
                },
                Drivers = new List<Driver>
                {
                    new Driver {Id = Guid.NewGuid(), Name = "Driver 1"},
                    new Driver {Id = Guid.NewGuid(), Name = "Driver 2"}
                }
            },
            new Trip
            {
                Id = Guid.NewGuid(),
                Name = "Trip 2",
                StartTime = DateTime.Now.AddHours(4),
                EndTime = DateTime.Now.AddHours(7),
                Destination = "Destination B",
                Orders = new List<Order>
                {
                    new Order { Id = Guid.NewGuid(), Customer_Id = Guid.NewGuid(), Details = "Details C", OrderTime = DateTime.Now.AddHours(4) }
                },
                Drivers = new List<Driver>
                {
                    new Driver { Id = Guid.NewGuid(), Name = "Driver 3" }
                }
            }
        };

            return trips;
        }

        public List<OrderRequest> SeedOrderRequests()
        {
            var orderRequests = new List<OrderRequest>
        {
            new OrderRequest
            {
                Id = Guid.NewGuid(),
                Customer_Id = Guid.NewGuid(),
                Details = "Details X",
                Time = DateTime.Now
            },
            new OrderRequest
            {
                Id = Guid.NewGuid(),
                Customer_Id = Guid.NewGuid(),
                Details = "Details Y",
                Time = DateTime.Now.AddMinutes(15)
            }
        };

            return orderRequests;
        }

        public List<Route> SeedRoutes()
        {
            var routes = new List<Route>
        {
            new Route
            {
                Id = Guid.NewGuid(),
                Name = "Route 1",
                Waypoints = new List<Location>
                {
                    new Location { Id = Guid.NewGuid(), Name = "Waypoint A", Latitude = 123.456, Longitude = 789.012 },
                    new Location { Id = Guid.NewGuid(), Name = "Waypoint B", Latitude = 234.567, Longitude = 890.123 }
                },
                PlannedStartTime = DateTime.Now,
                PlannedEndTime = DateTime.Now.AddHours(3)
            },
            new Route
            {
                Id = Guid.NewGuid(),
                Name = "Route 2",
                Waypoints = new List<Location>
                {
                    new Location { Id = Guid.NewGuid(), Name = "Waypoint C", Latitude = 345.678, Longitude = 901.234 }
                },
                PlannedStartTime = DateTime.Now.AddHours(4),
                PlannedEndTime = DateTime.Now.AddHours(7)
            }
        };

            return routes;
        }

        public List<Vehicle> SeedVehicles()
        {
            var vehicles = new List<Vehicle>
        {
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Name = "Vehicle 1",
                LicensePlate = "ABC123",
                Model = "Model X",
                Year = 2020
            },
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Name = "Vehicle 2",
                LicensePlate = "XYZ789",
                Model = "Model Y",
                Year = 2022
            }
        };

            return vehicles;
        }

        // Similar methods for other classes...

        public List<Compliance> SeedComplianceRecords()
        {
            var complianceRecords = new List<Compliance>
        {
            new Compliance
            {
                Id = Guid.NewGuid(),
                Type = "License Compliance",
                Date = DateTime.Now,
                IsCompliant = true
            },
            new Compliance
            {
                Id = Guid.NewGuid(),
                Type = "Safety Inspection",
                Date = DateTime.Now.AddMonths(2),
                IsCompliant = false
            }
        };

            return complianceRecords;
        }

        public List<Notification> SeedNotifications()
        {
            var notifications = new List<Notification>
        {
            new Notification
            {
                Id = Guid.NewGuid(),
                Message = "Notification 1",
                TimeStamp = DateTime.Now
            },
            new Notification
            {
                Id = Guid.NewGuid(),
                Message = "Notification 2",
                TimeStamp = DateTime.Now.AddMinutes(10)
            }
        };

            return notifications;
        }

        public List<Driver> SeedDrivers()
        {
            var drivers = new List<Driver>
        {
            new Driver
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                LicenseNumber = "123456",
                LicenseExpiration = DateTime.Now.AddYears(2)
            },
            new Driver
            {
                Id = Guid.NewGuid(),
                Name = "Jane Smith",
                LicenseNumber = "789012",
                LicenseExpiration = DateTime.Now.AddYears(1)
            }
        };

            return drivers;
        }

        public List<Product> SeedProducts()
        {
            var Products = new List<Product>
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product A",
                StockQuantity = 100
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product B",
                StockQuantity = 50
            }
        };

            return Products;
        }

        public List<Order> SeedOrders()
        {
            var orders = new List<Order>
        {
            new Order
            {
                Id = Guid.NewGuid(),
                Customer_Id = Guid.NewGuid(),
                Details = "Details X",
                OrderTime = DateTime.Now
            },
            new Order
            {
                Id = Guid.NewGuid(),
                Customer_Id = Guid.NewGuid(),
                Details = "Details Y",
                OrderTime = DateTime.Now.AddMinutes(15)
            }
        };

            return orders;
        }

        public List<Expense> SeedExpenses()
        {
            var expenses = new List<Expense>
        {
            new Expense
            {
                Id = Guid.NewGuid(),
                Type = "Fuel",
                Amount = 100.00M,
                Date = DateTime.Now
            },
            new Expense
            {
                Id = Guid.NewGuid(),
                Type = "Maintenance",
                Amount = 250.00M,
                Date = DateTime.Now.AddHours(2)
            }
        };

            return expenses;
        }

        public List<DriverAssignment> SeedDriverAssignments()
        {
            var assignments = new List<DriverAssignment>
        {
            new DriverAssignment
            {
                Id = Guid.NewGuid(),
                Driver_Id = Guid.NewGuid(),
                Vehicle_Id = Guid.NewGuid(),
                AssignmentStartTime = DateTime.Now,
                AssignmentEndTime = DateTime.Now.AddHours(3)
            },
            new DriverAssignment
            {
                Id = Guid.NewGuid(),
                Driver_Id = Guid.NewGuid(),
                Vehicle_Id = Guid.NewGuid(),
                AssignmentStartTime = DateTime.Now.AddHours(4),
                AssignmentEndTime = DateTime.Now.AddHours(7)
            }
        };

            return assignments;
        }
    }
}
