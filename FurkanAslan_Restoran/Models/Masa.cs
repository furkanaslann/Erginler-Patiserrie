using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Masa
    {
		[Key]
        public int Id { get; set; }
        public Yemek Yemek { get; set; }
        public YemekDurum YemekDurum { get; set; }
        public Garson Garson { get; set; }
        public Siparis Siparis{ get; set; }

    }
}
