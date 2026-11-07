
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; } = "";

        [BindProperty]
        public decimal Price { get; set; }

        public bool ProductAdded { get; set; }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(Name) || Price <= 0)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Informe um nome e um preço válido."
                );

                return;
            }

            ProductAdded = true;
        }
    }
}
