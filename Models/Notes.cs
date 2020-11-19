using System;
using System.ComponentModel.DataAnnotations;

namespace StickyNotes.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}