using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Model.Model
{
    [Table("Lessons")]
    public class Lesson
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
        [Required]
        [MaxLength(50)]
        public string Url_Image { set; get; }
        [Required]
        [MaxLength(50)]
        public string Url_Video { set; get; }

        [Required]
        [MaxLength(50)]
        public string Id_Text { set; get; }

        [Required]
        [MaxLength(50)]
        public string Id_Course { set; get; }

        [ForeignKey("Id_Course")]
        public virtual Course Courses { set; get; }

        public virtual IEnumerable<Text> Texts { set; get; }

    }
}
