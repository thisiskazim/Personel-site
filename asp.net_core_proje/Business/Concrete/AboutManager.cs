using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class AboutManager : IAboutServices
	{
		IAbout _aboutDal;
		public AboutManager(IAbout aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About t)
        {
         
            _aboutDal.Insert(t);

        }

        public List<About> TGetAll()
		{
		return _aboutDal.GetAll();
				
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public void TDelete(About t)
		{
		  _aboutDal.Delete(t);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
