using System;
using System.ComponentModel.DataAnnotations;

namespace Magile.Domain.ViewModels.Role
{
    public class RoleUpdateViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string UserUpdateAt { get; set; }
    }
}
