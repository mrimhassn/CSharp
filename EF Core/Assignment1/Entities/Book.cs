using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore1.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Isbn { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public int PublicationYear { get; set; }
        public bool IsInStock { get; set; }
    }
}
