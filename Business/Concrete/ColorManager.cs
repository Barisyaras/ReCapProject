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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public bool Add(Color color)
        {
           
            if (string.IsNullOrWhiteSpace(color.Name))
            {
                return false;
            }
            else
            {
                _colorDal.Add(color);
                return true;
            }
        }
        public bool Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
