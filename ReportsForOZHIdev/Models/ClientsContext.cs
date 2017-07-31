using System.Data.Entity;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext() : base("ReportsForOZHIdev") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}