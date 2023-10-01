using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Yemek
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public YemekKategorileri YemekKategorileri { get; set; }
        public YemekDurum YemekDurum { get; set; }
        public Siparis Siparis { get; set; }
        public Sef Sef { get; set; }
        public Garson   Garson { get; set; }
        public Masa Masa { get; set; }
        public Musteri Musteri { get; set; }
    }
}
