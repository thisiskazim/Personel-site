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
    public class ContactManager : IContactService
    {
		IContact _contactDal;

        public ContactManager(IContact contactDal)
        {
            _contactDal = contactDal;
        }

		public void TAdd(Contact t)
		{
			_contactDal.Insert(t);
				
		}
		public List<Contact> TGetAll()
		{
			return _contactDal.GetAll();
		}

		public Contact TGetById(int id)
		{
			return _contactDal.GetById(id);
		}

		public void TDelete(Contact t)
		{
			_contactDal.Delete(t);
		}

		public void TUpdate(Contact t)
		{
			_contactDal.Update(t);
		}

		public Contact TContactwithAbout()
		{
			return _contactDal.GetContactwithAbout();
		}


	}
}
