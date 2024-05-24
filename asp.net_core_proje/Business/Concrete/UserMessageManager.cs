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
    public class UserMessageManager : IUserMessageServices
    {
        IUserMessage _user;
        public UserMessageManager(IUserMessage user)
        {
            _user = user;
        }

        public void TAdd(UserMessage t)
        {
            _user.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
           _user.Delete(t);
        }

        public List<UserMessage> TGetAll()
        {
            return _user.GetAll();
        }

        public UserMessage TGetById(int id)
        {
              return  _user.GetById(id);
        }

        public void TUpdate(UserMessage t)
        {
            _user.Update(t);
        }
    }
}
