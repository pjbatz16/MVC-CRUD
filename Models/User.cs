using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please Enter Complete Name!")]
        public string Name { get; set; }

        [Required]
        [Range(20,30)]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
