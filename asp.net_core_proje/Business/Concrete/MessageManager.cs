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
    public class MessageManager : IContactMessageService
	{
        IContactMessage _messageDal;

        public MessageManager(IContactMessage messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(ContactMessage t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(ContactMessage t)
        {
            _messageDal.Delete(t);
        }

        public List<ContactMessage> TGetAll()
        {
            return _messageDal.GetAll();
        }

        public ContactMessage TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public void TUpdate(ContactMessage t)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
