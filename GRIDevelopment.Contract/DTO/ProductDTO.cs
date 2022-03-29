using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.Contract.DTO
{
    public class ProductDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Application type is required")]
        public string Application { get; set; }


        [Required(ErrorMessage = "Rim Size is required")]
        public string RimSize { get; set; }

        [Required(ErrorMessage = "Tube Size is required")]
        public string TubeSize { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
    }
}
