﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.ViewModels
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string EncryptedPassword { get; set; }
    }
}
