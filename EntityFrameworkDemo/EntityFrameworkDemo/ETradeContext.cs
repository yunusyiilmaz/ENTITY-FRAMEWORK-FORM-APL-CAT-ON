using System;
using System.Collections.Generic;
using System.Data.Entity;// bu kütüphaneyi ekliyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
