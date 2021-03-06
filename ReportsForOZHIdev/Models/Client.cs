﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportsForOZHIdev.Models
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDClient { get; set; }

        public int IDUser { get; set; }
        
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

        public double? GST { get; set; }

        public double? PST { get; set; }

        public double? TotalLabour { get; set; }

        public double? TotalMaterial { get; set; }

        public double? GrandTotal { get; set; }
    }
}