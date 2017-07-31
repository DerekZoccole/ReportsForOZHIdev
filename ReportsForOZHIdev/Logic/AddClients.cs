using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Logic
{
    public class AddClients
    {
        public bool AddClient(string FirstNationName)
        {
            var myClient = new Client();
            myClient.FirstNationName = FirstNationName;

            using (ClientsContext _db = new ClientsContext())
            {
                // Add client to DB
                _db.Clients.Add(myClient);
                _db.SaveChanges();
            }

            return true;
        }
    }
}