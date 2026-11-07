
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new();

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Name = "Notebook", Price = 3500.00m },
                new Product { Name = "Smartphone", Price = 2200.00m },
                new Product { Name = "Headset", Price = 250.00m }
            };
        }
    }

    public class Product
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}
