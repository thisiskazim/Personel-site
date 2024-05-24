using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ServiceManager : IServicesService
    {
        IServices _serviceDal;

        public ServiceManager(IServices serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Services t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Services t)
        {
            _serviceDal.Delete(t);
        }

        public List<Services> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Services TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TUpdate(Services t)
        {
            _serviceDal.Update(t);
        }

        public List<Services> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
