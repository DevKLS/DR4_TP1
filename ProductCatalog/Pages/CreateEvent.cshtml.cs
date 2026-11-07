
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCatalog.Models;

namespace ProductCatalog.Pages
{
    public class CreateEventModel : PageModel
    {
        private readonly Action<Event> _eventCreated;

        public CreateEventModel(Action<Event> eventCreated)
        {
            _eventCreated = eventCreated;
        }

        [BindProperty]
        public Event NewEvent { get; set; } = new();

        public bool EventCreated { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(NewEvent.Title) ||
                string.IsNullOrWhiteSpace(NewEvent.Location) ||
                NewEvent.Date == default)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Preencha todos os campos corretamente."
                );

                return;
            }

            // Dispara o delegate ao cadastrar o evento
            _eventCreated(NewEvent);

            EventCreated = true;
        }
    }
}
