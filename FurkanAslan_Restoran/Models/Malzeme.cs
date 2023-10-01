using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Malzeme
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Adet { get; set; }
        public string Skt { get; set; }
        public string UretimYeri { get; set; }
        public string Sube { get; set; }
        public Siparis Siparis { get; set; }
        public Sef Sef { get; set; }
    }
}

