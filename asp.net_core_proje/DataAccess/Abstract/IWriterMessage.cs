using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IWriterMessage : IGeneric<WriterMessage>
	{
		List<WriterMessage> GetByFilter(Expression<Func<WriterMessage, bool>> filter);
	}
}
