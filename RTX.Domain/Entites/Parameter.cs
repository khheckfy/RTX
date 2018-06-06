using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RTX.Domain.Entites
{
    [Table("Parameters")]
    public class Parameter
    {
        [Key]
        public int ParameterId { set; get; }
        [StringLength(255)]
        public string ParameterName { set; get; }

    }
}
