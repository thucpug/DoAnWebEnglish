using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Model.Model
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        public int? STT { set; get; }
        [Required]
        [MaxLength(256)]
        public string Search { set; get; }

        [Required]
        [MaxLength(256)]
        public string Notice { set; get; }

        public virtual IEnumerable<Course> Courses { set; get; }
    }
}
