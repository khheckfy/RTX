using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTX.Domain.Entites
{
    [Table("ItemTypes")]
    public class ItemType
    {
        [Key]
        public int ItemTypeId { set; get; }
        [StringLength(255)]
        public string Name { set; get; }
        [StringLength(512)]
        public string Alias { set; get; }

        public int? ParentItemTypeId { set; get; }
        public virtual ItemType ParentItemType { get; set; }
        public virtual ICollection<ItemType> ChildrenItemTypes { get; set; }

        public virtual ICollection<Item> Items { set; get; }
    }
}
