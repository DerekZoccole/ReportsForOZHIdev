using System.Data.Entity;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext() : base("ReportsForOZHIdev") { }
        public DbSet<Client> Clients { get; set; }
    }
}