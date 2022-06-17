using System;
using System.ComponentModel.DataAnnotations;

namespace Magile.Domain.ViewModels.Branch
{
    public class BranchUpdateViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public string ExternalId { get; set; }
        [Required]
        public string UserUpdateAt { get; set; }
        public bool Matrix { get; set; }
        public bool IsActive { get; set; }

    }
}