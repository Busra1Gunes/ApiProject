using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        //constroctor bellekte referans alındığı zaman çalışacak olan blog
        public InMemoryProductDal()
        {
                _products = new List<Product> 
                {
                    new Product{ProductID=1,ProductName="Bardak",CategoryId=1,UnitPrice=15,UnitsInStock=20},
                    new Product{ProductID=2,ProductName="Tabak",CategoryId=2,UnitPrice=20,UnitsInStock=15},
                    new Product{ProductID=3,ProductName="Sürahi",CategoryId=3,UnitPrice=25,UnitsInStock=60},
                    new Product{ProductID=4,ProductName="Kaşık",CategoryId=4,UnitPrice=65,UnitsInStock=15},
                    new Product{ProductID=4,ProductName="Çatal",CategoryId=4,UnitPrice=60,UnitsInStock=20},
                };
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=_products.SingleOrDefault(p=>p.ProductID==product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            List<Product> productAllybyCategory = _products.Where(p => p.CategoryId == categoryId).ToList();
            return productAllybyCategory;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;
        }
    }
}
