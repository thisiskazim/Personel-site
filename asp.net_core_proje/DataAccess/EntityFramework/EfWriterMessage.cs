using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
	public class EfWriterMessage : GenericRepository<WriterMessage>, IWriterMessage
	{
		public List<WriterMessage> GetByFilter(Expression<Func<WriterMessage, bool>> filter)
		{
			using var c = new Context();
			return c.Set<WriterMessage>().Where(filter).ToList();
		}
	}
}
