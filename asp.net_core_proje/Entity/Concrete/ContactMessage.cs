using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class ContactMessage
	{
		[Key]
		public int ContactMessageID { get; set; }
        public string  Name { get; set; }
		[EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]

		public string Mail { get; set; }
		[MaxLength(150)]
		public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; } //OKUNDU MU OKUNMADI MI BİLDİRİMİ
    }
}
