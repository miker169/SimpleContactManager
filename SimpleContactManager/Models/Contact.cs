﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleContactManager.Models
{
    using System.Globalization;

    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture, "api/contacts/{0}", this.ContactId);
            }
            set
            {
                
            }
        }

    }
}