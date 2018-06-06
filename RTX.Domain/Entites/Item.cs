using RTX.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTX.Domain.Entites
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { set; get; }
        [StringLength(512)]
        public string Name { set; get; }
        [StringLength(1024)]
        public string Description { set; get; }
        
        public int? Price { set; get; }
        public PriceTypes? PriceType { set; get; }

        public DateTime CreatedOn { set; get;}
        public DateTime ModifiedOn { set; get; }

        public bool IsActive { set; get; }

        public int AddressId { set; get; }
        public Address Address { set; get; }

        public int UserId { set; get; }
        public User User { set; get; }

        public int ItemTypeId { set; get; }
        public ItemType ItemType { set; get; }
    }
}
