using core_proje_api.Concrete;
using core_proje_api.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core_proje_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }



        [HttpGet]
        public IActionResult Get()
        {
          using Context c = new Context();
            return Ok(c.Category.ToList()); 

        }

        [HttpGet("{id}")]
        public IActionResult GetID(int id)
        {
            using Context c = new Context();
            return Ok(c.Category.Find(id));

        }

        [HttpPost]
        public IActionResult Add(Category a)
        {
            using Context c = new Context();
            c.Category.Add(a);
            c.SaveChanges();
            return Created("",a);

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            using Context c = new Context();
           var value= c.Category.Find(id);
            if (value ==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }

        }

        [HttpPut]
        public IActionResult Update(Category p)
        {
            using Context c = new Context();
            var val = c.Find<Category>(p.CategoryID);
            if (val ==null)
            {
                return NotFound();
            }
            else
            {
                val.Name = p.Name;
                c.Category.Update(val);
                c.SaveChanges();
                return NoContent();
            }


        }





    }
}
