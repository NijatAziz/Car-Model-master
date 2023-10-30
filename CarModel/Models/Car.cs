using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarModel.Models
{
    public class Car : PageModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Brand CarBrand { get; set; }
        public Model CarModel { get; set; }

    }
}
