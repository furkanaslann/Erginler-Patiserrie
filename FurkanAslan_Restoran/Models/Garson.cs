using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Garson
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int TC { get; set; }
        public string Sube { get; set; }
    }
}
