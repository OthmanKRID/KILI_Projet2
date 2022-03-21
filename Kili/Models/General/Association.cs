using Kili.Models.General;
using System.ComponentModel.DataAnnotations;

namespace Kili.Models.General
{
    public class Association
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nom { get; set; }
        [Required]
        public Adresse Adresse { get; set; }
        [Required]
        public string Theme { get; set; }
        public int? UserAccountId { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
