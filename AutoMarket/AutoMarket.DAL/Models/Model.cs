﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class Model : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public virtual Brand Brand { get; set; }
    }
}