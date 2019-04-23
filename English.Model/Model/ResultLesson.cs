using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Model.Model
{
    [Table("ResultLessons")]
    public class ResultLesson
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Id_User { set; get; }

        [Required]
        [MaxLength(50)]
        public string Id_Lesson { set; get; }

        public int? STT { set; get; }
        [Required]
        public int Math { set; get; }
        [Required]
        [MaxLength(256)]
        public string Search { set; get; }
    }
}
