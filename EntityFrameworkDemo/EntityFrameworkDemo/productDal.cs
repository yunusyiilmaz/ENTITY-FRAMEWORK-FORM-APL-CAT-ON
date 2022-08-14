using System;
using System.Collections.Generic;
using System.Data.Entity;//bu kütüphane eklendi
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class productDal
    {
        public List<Product> GetAll()//VERİLERİ GETİRMEK İÇİN
        {
            using (ETradeContext context = new ETradeContext())// USİNG KULLANMA SEBEBİ KOD KULLANILDIKTAN SONRA ATILMASI İÇİNDİR BÖYLELİKLE ÇALIŞMA HIZI ARTAR.
            {
                return context.Products.ToList();
            }
        }
        public void Add(Product product)//VERİ EKLEMEK İÇİN
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges(); 
            }
        }
        public void Update(Product product)// VERİLERİ GÜNCELLEMEK İÇİN
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity=context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)// VERİLERİ SİLMEK İÇİN
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
