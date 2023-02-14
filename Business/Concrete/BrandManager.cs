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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public bool Add(Brand brand)
        {
            if (string.IsNullOrWhiteSpace(brand.Name))
            {
                return false;
            }
            else
            {
                _brandDal.Add(brand);
                return true;
            }
        }

        public bool Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
