using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Skill // yeteneler ve dereceler
	{
		[Key]
		public int SkillID { get; set; }
		[MaxLength(30,ErrorMessage ="En fazla 30 karakter olabilir")]
		[MinLength(2,ErrorMessage ="En az 2 karakter olabilir")]
		[Required(ErrorMessage ="Yetenek Alanı boş bırakılamaz")]
		public string Title { get; set; }
		[Range(1, 100, ErrorMessage = "Değer 1 ile 100 arasında olmalıdır.")]
		public int Value { get; set; }
    }
}
//burada dataannotations kullandık fakat fluentvalidation da kullanabilirdik