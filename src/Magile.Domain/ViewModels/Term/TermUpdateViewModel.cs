﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magile.Domain.ViewModels.Term
{
    public class TermUpdateViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Base64 { get; set; }
        public bool IsActive { get; set; }
        public string UserUpdateAt { get; set; }
    }
}
