using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

///For defining string lengths
using System.ComponentModel.DataAnnotations;

namespace MDE2018.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage ="This is must")]
        [StringLength(25)] //uses dataAnnotations
        public string Firstname { get; set; }

        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        public DateTime? DOB { get; set; }
        [RegularExpression("http://.*")]
        public string PictureURL { get; set; }

    }
}
