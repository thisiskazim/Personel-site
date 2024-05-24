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
    public class SkillManager : ISkillService
    {
        ISkill _skillDal;

        public SkillManager(ISkill skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
            
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetAll()
        {
            return _skillDal.GetAll();
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
