using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Models
{
    public class ReportActions : IDisposable
    {
        public int ReportID { get; set; }

        private ClientsContext _db = new ClientsContext();

        public const string ReportSessionKey = "ReportId";

        public void AddToReport(int id)
        {
            // Retrieve the product from the database
            ReportID = GetReportId();

            var reportItem = _db.Reports.SingleOrDefault(r => r.IDReport == ReportID && r.IDClient == id);
            if (reportItem == null)
            {
                // Create a new report if one doesn't exist from existing data
                reportItem = new Report
                {
                    IDClient = 
                }
            }
        }
    }
}