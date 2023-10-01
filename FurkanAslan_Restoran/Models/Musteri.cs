using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Musteri
    {
		[Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public Masa Masa { get; set; } // Navigation property (MasaId)
        public Siparis Siparis { get; set; }
    }
}
