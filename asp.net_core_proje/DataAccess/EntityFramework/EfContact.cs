	using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfContact : GenericRepository<Contact>,IContact
    {


        public Contact GetContactwithAbout()
        {
            using (var a = new Context())
            {
                return a.Contacts.Include(x => x.About).FirstOrDefault();
            }


        }
    }
}
