using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Feature //baş tanıtım
	{
		[Key]
		public int FeatureID { get; set; }
		[MaxLength(30)] // En fazla 50 karakter

		public string Name { get; set; }
        public string Department { get; set; }
      

    }
}
