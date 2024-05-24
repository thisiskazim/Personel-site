using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class WriterMessageManager : IWriterMessageServices
	{
		IWriterMessage _writerMessage;

		public WriterMessageManager(IWriterMessage writerMessage)
		{
			_writerMessage = writerMessage;
		}

		public void TAdd(WriterMessage t)
		{
			_writerMessage.Insert(t);
		}

		public void TDelete(WriterMessage t)
		{
			_writerMessage.Delete(t);
		}

		public List<WriterMessage> TGetAll()
		{
			throw new NotImplementedException();
		}

	

		public WriterMessage TGetById(int id)
		{
		 return _writerMessage.GetById(id);
		}

        public List<WriterMessage> TGetReceiverFilter(string p)
        {
			return _writerMessage.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> TGetSendFilter(string p)
        {
            return _writerMessage.GetByFilter(x => x.Sender == p);
        }

        public void TUpdate(WriterMessage t)
		{
			throw new NotImplementedException();
		}
	}
}
