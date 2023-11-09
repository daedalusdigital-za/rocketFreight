using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketFreight.Models
{
    // Dashboard
    public class Dashboard
    {
        public List<Trip> OngoingTrips { get; set; }
        public List<OrderRequest> OrderRequests { get; set; }
        public List<Route> Routes { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Product> Inventory { get; set; }
    }

    // Trip Order Management
    public class TripOrderManagement
    {
        public List<Trip> OngoingTrips { get; set; }
        public List<Order> OrderHistory { get; set; }
        public List<Route> PlannedRoutes { get; set; }
        public List<Expense> Expenses { get; set; }
    }

    // Route Management
    public class RouteManagement
    {
        public List<Route> PlannedRoutes { get; set; }
        public List<Expense> Expenses { get; set; }
    }

    // Fleet Management
    public class FleetManagement
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<DriverAssignment> DriverAssignments { get; set; }
        public List<Notification> Notifications { get; set; }
    }

    // Driver Management
    public class DriverManagement
    {
        public List<Driver> Drivers { get; set; }
        public List<DriverAssignment> DriverAssignments { get; set; }
        public List<Compliance> ComplianceRecords { get; set; }
    }

    // Inventory Management
    public class InventoryManagement
    {
        public List<Product> Inventory { get; set; }
        public List<Order> BackOrders { get; set; }
    }
}
