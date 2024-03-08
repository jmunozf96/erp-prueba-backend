﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSecurity.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        
        public required String Email { get; set; }

        public required String Name { get; set; }

        public required String LastName { get; set; }

        public required String FullName { get; set; }

        public required String Password { get; set; }
    }
}
