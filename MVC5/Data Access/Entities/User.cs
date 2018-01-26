using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Entities
{
    [Table("Usuario")]
    public class User
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserId { get; set; }

        [StringLength(16,MinimumLength = 8)]
        [Required]
        [Column(Order = 1)]
        public string Password { get; set; }

        [StringLength(50)]
        [Required]
        [Column(Order = 2)]
        public string UserName { get; set; }

        [Required]
        [Column(Order = 3)]
        public string Email { get; set; }

        public byte[] Avatar { get; set; }
    }
}
