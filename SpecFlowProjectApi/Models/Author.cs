﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SpecFlowProjectApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public int IdBook { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
