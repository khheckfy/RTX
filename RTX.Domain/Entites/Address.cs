using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTX.Domain.Entites
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressId { set; get; }
        [StringLength(512)]
        public string Name { set; get; }
        public decimal Lng { set; get; }
        public decimal Lat { set; get; }

        public virtual ICollection<User> Users { set; get; }
        public virtual ICollection<Item> Items { set; get; }

    }
}
