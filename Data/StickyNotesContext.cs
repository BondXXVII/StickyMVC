using Microsoft.EntityFrameworkCore;
using StickyNotes.Models;

namespace StickyNotes.Data
{
    public class StickyNotesContext : DbContext
    {
        public StickyNotesContext (DbContextOptions<StickyNotesContext> options)
            : base(options)
        {
        }

        public DbSet<Notes> Note { get; set; }
    }
}