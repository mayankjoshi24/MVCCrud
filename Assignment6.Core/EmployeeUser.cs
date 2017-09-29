using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Core
{
    public class EmployeeUser
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name  { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name ="Marital Status")]
        public bool Status { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }

    }
}
