using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class GuestbookContext : DbContext
    {
        public GuestbookContext (DbContextOptions<GuestbookContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication6.Models.GuestbookEntry> GuestbookEntry { get; set; }
    }
}
