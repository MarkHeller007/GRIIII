using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.DAL.DomainModel
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SupplierName { get; set; }
        public string SupAddress { get; set; }
        
        public string SupContact { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;



    }
}
