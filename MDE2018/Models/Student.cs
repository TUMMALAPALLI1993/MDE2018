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
        [StringLength(25)] //uses dataAnnotations
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string PictureURL { get; set; }

    }
}
