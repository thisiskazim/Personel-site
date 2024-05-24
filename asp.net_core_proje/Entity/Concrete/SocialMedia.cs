using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class SocialMedia
	{
		[Key]
		public int SocialMeadiaID { get; set; }
		[MaxLength(20)] // En fazla 50 karakter
		public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
    }
}
