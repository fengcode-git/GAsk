using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.DAL;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    public class BottomNavbarViewComponent: ViewComponent
    {
        private readonly PersonService personService;

        public BottomNavbarViewComponent(PersonService personService)
        {
            this.personService = personService ?? throw new ArgumentNullException(nameof(personService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var person = await personService.GetCurrentPersonViewAsync();
            BottomNavbarComponentModel model = new BottomNavbarComponentModel { Person = person };
            return View(model);
        }
    }
}
