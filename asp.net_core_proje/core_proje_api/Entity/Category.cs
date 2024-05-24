using System.ComponentModel.DataAnnotations;

namespace core_proje_api.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
