using SQLite.CodeFirst;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWinFormCRUD.Data.Tables
{
    [Table("Crews")]
    public class Crew
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public string NamePerson { get; set; }

        [Unique]
        [Required]
        public string IdNumberCar { get; set; }

        public string Transfer { get; set; }

    }
}
