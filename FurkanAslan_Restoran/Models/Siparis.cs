using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Siparis
    {
		[Key]
        public int Id { get; set; }
        public Musteri Musteri { get; set; }
        public Masa Masa { get; set; }
        public Malzeme Malzeme { get; set; }
        public Icecek Icecek { get; set; }
        public Yemek Yemek { get; set; }
        public YemekDurum YemekDurum { get; set; }
        public Garson Garson { get; set; } // Navigation property

    }
}
