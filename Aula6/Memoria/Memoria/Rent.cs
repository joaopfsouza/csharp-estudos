﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Memoria
{
    class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
