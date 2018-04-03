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
    [Table("Posts")]
    public class Post :Auditable
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        [Required]
        public string PostCategoryID { set; get; }
        public string Image { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        [Required]
        public int ViewCount { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
        [ForeignKey("PostCategoryID")]
        public virtual PostCategory PostCategory { set; get; }


    }
}
