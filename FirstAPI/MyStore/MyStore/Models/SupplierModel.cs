using System.ComponentModel.DataAnnotations;

namespace MyStore.Models
{
    public class SupplierModel
    {
        public int Supplierid { get; set; }

        [Required]
        public string Companyname { get; set; } 

        [Required]
        public string Contactname { get; set; }
        [Required]
        public string Contacttitle { get; set; } 

        [Required]
        public string Address { get; set; } 

        public string City { get; set; } 

        public string Region { get; set; }

        public string Postalcode { get; set; }

        public string Country { get; set; } 

        [Required]
        [Phone]
        public string Phone { get; set; } 
        public string Fax { get; set; }


    }
}
