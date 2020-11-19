using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        [MaxLength(56)]
        public string Type { set; get; }
        IEnumerable<ProductTag> productTags { set; get; }
    }
}