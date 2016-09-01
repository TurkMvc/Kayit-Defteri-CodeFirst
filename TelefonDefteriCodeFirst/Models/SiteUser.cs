using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteriCodeFirst.Models
{
    [Table("SiteUsers")]
    public partial class SiteUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(25), DisplayName("Ad�")]
        public string Name { get; set; }

        [StringLength(25), DisplayName("Soyad�")]
        public string Surname { get; set; }

        [StringLength(80), DisplayName("E-Posta"), Required, EmailAddress()]
        public string Email { get; set; }

        [StringLength(25), DisplayName("Kullan�c� Ad�"), Required]
        public string Username { get; set; }

        [StringLength(25), DisplayName("�ifre"), Required]
        public string Password { get; set; }
    }
}
