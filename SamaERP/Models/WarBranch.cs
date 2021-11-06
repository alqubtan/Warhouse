using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class WarBranch
    {
        [Key]
        public Guid Id { get; set; }
        
        [StringLength(1000, ErrorMessage ="You must type less than 1000 characters")]
        
        public string BranchName { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string BranchAdresss { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string BranchCity { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "You must type less than 1000 characters")]
        public string BranchCountry { get; set; }
    }
}
