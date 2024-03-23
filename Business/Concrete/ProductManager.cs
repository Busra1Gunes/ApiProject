using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //bir iş sınıfı başka bir iş sınıfını new'lemez new'leme işlemini iş sınıflarının dışına yazarız 
        IProductDal _productDal; //ampül generic constroctor

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları 
            //Yetkisi var mı??
            return _productDal.GetAll();


        }
    }
}
