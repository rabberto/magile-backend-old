using System.ComponentModel.DataAnnotations;

namespace Magile.Domain.ViewModels.Role
{
    public class RoleInsertViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string UserCreateAt { get; set; }
    }
}
