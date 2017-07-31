using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportsForOZHIdev.Models
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDClient { get; set; }

        [Required, StringLength(100), Display(Name = "FNName")]
        public string FirstNationName { get; set; }
    }
}