using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportsForOZHIdev.Models
{
    public class WorkItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDWorkItem { get; set; }

        public int IDReport { get; set; }

        public double? LabourEstimate { get; set; }

        public double? MaterialEstimate { get; set; }

        public string Priority { get; set; }

        public string Section { get; set; }

        public double? Total { get; set; }

        public string Urgency { get; set; }

        public string WorkItemNumber { get; set; }
        
        public string WorkItemDescription { get; set; }
    }
}