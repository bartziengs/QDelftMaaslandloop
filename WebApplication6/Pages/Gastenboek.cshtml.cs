using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    public class GastenboekModel : PageModel
    {
        public WebApplication6.Models.GuestbookContext _context;

        public GastenboekModel(WebApplication6.Models.GuestbookContext context)
        {
            _context = context;
        }

        public IList<GuestbookEntry> GuestbookEntry { get;set; }

        public async Task OnGetAsync()
        {
            GuestbookEntry = await _context.GuestbookEntry.ToListAsync();
        }
    }
}
