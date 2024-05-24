using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class About
	{
        [Key]
        public int AboutID { get; set; }
       
        public string Description { get; set; }

        public byte Age { get; set; }
		[EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
		public string Email { get; set; }
		[Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]

		public string Phone { get; set; }
        public string Adrress { get; set; }
        public string ImageUrl { get; set; }
     


    }
}
