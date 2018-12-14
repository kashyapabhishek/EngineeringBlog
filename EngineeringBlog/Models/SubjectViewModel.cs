using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EngineeringBlog.Models
{
    public class SubjectViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MaxLength(50,ErrorMessage ="Please Enter the name of Concept")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "About")]
        public string About { get; set; }

        [Required]
        [Display(Name = "Url")]
        public string Url { get; set; }
    }
}