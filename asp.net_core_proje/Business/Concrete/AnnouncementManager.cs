using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementServices
    {
         IAnnouncement _efAnnouncement;
       
       

        public AnnouncementManager(IAnnouncement efAnnouncement)
        {
            _efAnnouncement = efAnnouncement;
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetAll()
        {
           return _efAnnouncement.GetAll();
        }

        public Announcement TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
