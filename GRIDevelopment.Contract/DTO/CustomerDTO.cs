using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.Contract.DTO
{
    public class CustomerDTO
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string customer_name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string customer_address { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(10, ErrorMessage = "should have minimum of 10 digits", MinimumLength = 10)]
        [RegularExpression(@"^\(?[0-9]{3}\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string customer_contact { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Not a valid email address")]
        public string customer_email { get; set; }
    }
}
