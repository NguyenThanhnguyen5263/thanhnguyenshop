using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Tag
    {
        [Key]
        public string ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get;}


    }
}
