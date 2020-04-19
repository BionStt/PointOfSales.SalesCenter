﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSales.SalesCenter.Application.Models.Account
{
    public class LoggedInUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public  List<string> Roles { get; set; }
        public bool? HasVerifiedEmail { get; set; }
        public bool? TFAEnabled { get; set; }
        public string Token { get; set; }
    }
}
