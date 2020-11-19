using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StickyNotes.Data;
using System;
using System.Linq;

namespace StickyNotes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StickyNotesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StickyNotesContext>>()))
            {
                // Look for any Notes.
                if (context.Note.Any())
                {
                    return;   // DB has been seeded
                }

                context.Note.AddRange(
                    new Notes
                    {
                        Title = "Note Numba 1",
                        Text = "What it do boo"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}