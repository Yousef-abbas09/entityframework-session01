using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore_assignment.Entities
{
    [Table("Books")]
    internal class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; }

        [Required, MaxLength(17)]
        public string ISBN { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public int Pages { get; set; }

        public int YearPublished { get; set; }

        public bool IsAvailable { get; set; }

        // FK + Navigation للمؤلف
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        // FK + Navigation للتصنيف
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
