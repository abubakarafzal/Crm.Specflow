﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vermaat.Crm.Specflow.Entities;

namespace Vermaat.Crm.Specflow
{
    public class UserDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserSettings UserSettings { get; set; } 
    }
}
