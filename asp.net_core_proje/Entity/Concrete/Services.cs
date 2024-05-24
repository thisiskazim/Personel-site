using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Services
	{
		[Key]
		public int ServicesID { get; set; }
		[MaxLength(50)] // En fazla 50 karakter

		public string Name { get; set; }
        public string ImagegUrl { get; set; }

    }
}
