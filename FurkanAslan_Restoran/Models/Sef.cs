using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Sef
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string Soyad { get; set; }
        public Malzeme Malzeme { get; set; }
        public YemekDurum YemekDurum { get; set; }
        public Yemek Yemek { get; set; }

    }
}
