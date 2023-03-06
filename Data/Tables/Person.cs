using SQLite.CodeFirst;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWinFormCRUD.Data.Tables
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Unique]
        public string Name { get; set; }

        public int? Age { get; set; }

        public int? ExperienceAge { get; set; }

        //public Crew Crew { get; set; }

        //public ICollection<Order> Orders { get; set; }
    }
}
