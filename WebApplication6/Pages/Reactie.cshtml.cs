using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    public class ReactieModel : PageModel
    {
        private readonly WebApplication6.Models.GuestbookContext _context;

        public ReactieModel(WebApplication6.Models.GuestbookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GuestbookEntry GuestbookEntry { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GuestbookEntry.Add(GuestbookEntry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Gastenboek");
        }
    }
}