using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    [Table("Crew")]
    public class Crew
    {
        public int Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string? TmdbUrl { get; set; }
        [MaxLength(2048)]
        public string? ProfilePath { get; set; }
    }
}
