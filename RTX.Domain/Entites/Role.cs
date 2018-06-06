using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTX.Domain.Entites
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public int RoleId { set; get; }
        [StringLength(255)]
        public string RoleName { set; get; }

        public virtual ICollection<User> Users { set; get; }
    }
}
