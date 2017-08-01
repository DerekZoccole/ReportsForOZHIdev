using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Models
{
    public class ReportActions : IDisposable
    {
        public string WorkItemID { get; set; }

        private ClientsContext _db = new ClientsContext();

        public const string WorkItemSessionKey = "ReportId";

        public void AddToReport(int id)
        {
            // Retrieve the work item from the database
            WorkItemID = GetWorkItemId();

            var reportItem = _db.Reports.SingleOrDefault(w => w.IDReport == Convert.ToInt16(WorkItemID) && w.IDClient == id);
            if (reportItem == null)
            {
                // Create a new report if one doesn't exist from existing data
                reportItem = new Report
                {
                    // TODO
                };

                // Add report to database
                _db.Reports.Add(reportItem);
            }

            _db.SaveChanges();
        }

        public void Dispose()
        {
            // TODO
        }

        public string GetWorkItemId()
        {
            if (HttpContext.Current.Session[WorkItemSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[WorkItemSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate random GUID using System.Guid class
                    Guid tempWorkItemId = Guid.NewGuid();
                    HttpContext.Current.Session[WorkItemSessionKey] = tempWorkItemId.ToString();
                }
            }
            return HttpContext.Current.Session[WorkItemSessionKey].ToString();
        }

        public List<WorkItem> GetWorkItems()
        {
            WorkItemID = GetWorkItemId();
            return _db.WorkItems.Where(w => w.IDWorkItem == Convert.ToInt16(WorkItemID)).ToList();
        }
    }
}