using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Content { get; set; }
        int a;
    }
}