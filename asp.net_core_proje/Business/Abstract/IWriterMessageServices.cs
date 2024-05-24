using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IWriterMessageServices : IGenericService<WriterMessage>
	{
	   	List<WriterMessage> TGetReceiverFilter(string p);
		 List<WriterMessage> TGetSendFilter(string p);
    }
}
