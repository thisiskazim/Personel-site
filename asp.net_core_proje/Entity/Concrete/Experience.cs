using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Experience:IValidatableObject //deneyim
	{
		[Key]
		public int ExperienceID { get; set; }
		[MaxLength(30)] // En fazla 30 karakter
		public string Name { get; set; }
        public string ImageUrl { get; set; }
		[MaxLength(350)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
     
        public DateTime FirstDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstDate >= FinishDate)
            {
                yield return new ValidationResult("Başlangıç tarihi bitiş tarihinden küçük olmalıdır.", new[] { nameof(FirstDate) });
            }
        }
    }
}
