using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore_assignment.Entities
{
    [Table("Authors")]
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(350)]
        public string? Bio { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}