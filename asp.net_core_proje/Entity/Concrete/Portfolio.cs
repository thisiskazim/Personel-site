using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Portfolio
	{
		[Key]
		public int PortfolioID { get; set; }
		[MaxLength(50)] // En fazla 30 karakter

		public string WebName { get; set; } //ae yazılım
        public string Department { get; set; } //web tasarım 
        public string BigImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string WebUrl { get; set; }
    }
}
