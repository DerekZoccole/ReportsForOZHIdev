using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ReportsForOZHIdev.Models;
using System.Collections.Generic;

namespace ReportsForOZHIdev.Models
{
    public class Report
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDReport { get; set; }

        public int IDClient { get; set; }

        public string FirstNationName { get; set; }

        public string FirstNationContactName { get; set; }

        public string ApplicantName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string CMHCAccountNumber { get; set; }

        public string Inspector { get; set; }

        public string LoanType { get; set; }

        public string Service { get; set; }

        public string EnvironmentalConcerns { get; set; }

        public List<WorkItem> WorkItems { get; set; }
    }
}