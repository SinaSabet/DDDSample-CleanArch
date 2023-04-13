﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buber.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string LastName { get; set; }= null!;
        public string Email { get; set; } = null!;  
        public string Password { get; set; } = null!;
    }
}
