﻿using System;
using System.Collections.Generic;

namespace api_student.Models
{
    public partial class Userauth
    {
        public int Userid { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }
}
