using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Announcement
    {
        [Key]
        public int ID { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
