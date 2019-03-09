﻿using System;
using System.Collections.Generic;

namespace DiplomApi.Models
{
    public partial class Company
    {
        public Company()
        {
            Employee = new HashSet<Employee>();
            Network = new HashSet<Network>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string ContactDetails { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<Network> Network { get; set; }
    }
}
