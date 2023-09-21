using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PantsController: ControllerBase
    {
        [HttpGet]
        public string GetPants()
        {
            return "Reading all pants";
        }

        [HttpGet("{id}")]
        public string GetPantByID(int id)
        {
            return $"Reading pant with ID: {id}";
        }

        [HttpPost]
        public string CreatePant()
        {
            return "Creating pant";
        }

        [HttpPut("{id}")]
        public string UpdatePant(int id) 
        {
            return $"Updating pant with ID: {id}";
        }

        [HttpDelete("{id}")]
        public string DeletePant(int id) 
        {
            return $"Deleting pant with ID: {id}";
        }
    }
}
