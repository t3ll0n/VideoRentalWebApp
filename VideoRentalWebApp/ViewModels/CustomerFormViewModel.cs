﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalWebApp.Models;

namespace VideoRentalWebApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                return Customer.Id != 0 ? "Edit Customer" : "New Customer";
            }
        }
    }
}