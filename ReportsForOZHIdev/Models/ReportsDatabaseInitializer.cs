using System.Collections.Generic;
using System.Data.Entity;

namespace ReportsForOZHIdev.Models
{
    public class ReportsDatabaseInitializer : DropCreateDatabaseIfModelChanges<ClientsContext>
    {
        protected override void Seed(ClientsContext context)
        {
            GetClients().ForEach(c => context.Clients.Add(c));
        }
        
        private static List<Client> GetClients()
        {
            var clients = new List<Client>
            {

            };
            return clients;
        }
    }
}