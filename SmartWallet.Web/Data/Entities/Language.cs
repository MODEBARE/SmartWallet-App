using System.ComponentModel.DataAnnotations;

namespace SmartWallet.Web.Data.Entities
{
    public class Language : BaseEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
