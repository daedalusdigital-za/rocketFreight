using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketFreight.Models
{
    public class Trip
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string Destination { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }

        public List<Order> Orders { get; set; }
        public List<Driver> Drivers { get; set; }
    }

    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }
    
    public class OrderRequest
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Customer_Id { get; set; }
        public string Details { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Route
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PlannedStartTime { get; set; }
        public DateTime PlannedEndTime { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }

        public List<Location> Waypoints { get; set; }
    }

    public class Location
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Driver
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiration { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }

        public List<DriverAssignment> Assignments { get; set; }
    }

    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }
    
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Category_Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public decimal StockValue { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Customer_Id { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class DriverAssignment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Driver_Id { get; set; }
        public Guid Vehicle_Id { get; set; }
        public DateTime AssignmentStartTime { get; set; }
        public DateTime AssignmentEndTime { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }

    public class Notification
    {
        [Key]
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Status { get; set; }
    }

    public class Compliance
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompliant { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiededOn { get; set; }
    }
}
