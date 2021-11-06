using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarProduct
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string ProductName { get; set; }
        
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductType { get; set; }
        [Required]
        public string Prod_MeasureUnit { get; set; }
        public bool HasExpireDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProductExpireDate { get; set; }
        [ForeignKey("Product")]
        public List<WarReceivedProduct> Products { get; set; }
    }
}
