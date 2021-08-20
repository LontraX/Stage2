using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveResume.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250,ErrorMessage ="wetin you dey type?")]
        public string Message { get; set; }
    }
}
