using Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Pages")]

    public class Page :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(250)]
        public string Name { set; get; }
        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }
        [MaxLength(256)]
        public string Content { set; get; }

    }
}
