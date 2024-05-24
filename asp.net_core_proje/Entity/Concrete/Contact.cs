using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactID { get; set; }
        public string Title { get; set; }
		[MaxLength(350)] // En fazla 350 karakter

		public string Description { get; set; }
        public About About { get; set; }
        public int AboutID { get; set; }
     



    }
}
