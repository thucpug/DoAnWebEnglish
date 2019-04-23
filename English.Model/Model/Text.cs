using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Model.Model
{
    [Table("Texts")]
    public class Text
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Question_A { set; get; }

        [Required]
        [MaxLength(50)]
        public string Question_B { set; get; }

        [Required]
        [MaxLength(50)]
        public string Question_C { set; get; }

        [Required]
        [MaxLength(50)]
        public string Question_D { set; get; }
        public int? STT { set; get; }
        [Required]
        [MaxLength(256)]
        public string Notice { set; get; }
        [Required]
        [MaxLength(50)]
        public string Result{ set; get; }
        [Required]
        [MaxLength(50)]
        public string Id_Lesson { set; get; }

        [ForeignKey("Id_Lesson")]
        public virtual Lesson Lessons { set; get; }
        

    }
}
