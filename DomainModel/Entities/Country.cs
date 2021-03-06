﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Country
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
