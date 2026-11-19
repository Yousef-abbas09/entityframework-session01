using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore_assignment.Entities
{
    [Table("Categories")]
    internal class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(350)]
        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}