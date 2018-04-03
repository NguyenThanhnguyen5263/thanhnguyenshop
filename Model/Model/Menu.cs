using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Menus")]
   public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; } // allow null 
        [Required] 
        public int MenuGroupID { set; get; }

        [ForeignKey("MenuGroupID")]
        public virtual MenuGroup Menugroup { set; get; }

        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }
        
    }
}
