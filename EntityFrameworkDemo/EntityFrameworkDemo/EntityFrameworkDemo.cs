﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnityPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
