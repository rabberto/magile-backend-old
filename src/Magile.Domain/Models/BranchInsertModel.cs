using System.ComponentModel.DataAnnotations;

namespace Magile.Domain.Models
{
    public class BranchInsertModel

    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public string ExternalId { get; set; }
        [Required]
        public string UserCreateAt { get; set; }
    }
}