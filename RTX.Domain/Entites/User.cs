using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTX.Domain.Entites
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { set; get; }
        [StringLength(255)]
        public string Email { set; get; }
        [StringLength(512)]
        public string Password { set; get; }
        [StringLength(255)]
        public string LastName { set; get; }
        [StringLength(255)]
        public string FirstName { set; get; }
        [StringLength(255)]
        public string MiddleName { set; get; }
        [StringLength(20)]
        public string Phone1 { set; get; }
        [StringLength(20)]
        public string Phone2 { set; get; }
        [StringLength(20)]
        public string Phone3 { set; get; }
        [StringLength(1024)]
        public string Description { set; get; }
        [StringLength(512)]
        public string CompanyName { set; get; }

        public bool IsActive { set; get; }
        public bool IsDelete { set; get; }
        [StringLength(1024)]
        public string Token { set; get; }

        public DateTime CreatedOn { set; get; }
        public DateTime ModifiedOn { set; get; }
        public DateTime? LastLogOn { set; get; }

        public int RoleId { set; get; }
        public Role Role { set; get; }

        public int AddressId { set; get; }
        public Address Address { set; get; }

        public virtual ICollection<Item> Items { set; get; }
    }
}
