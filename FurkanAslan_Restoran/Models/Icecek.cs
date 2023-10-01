using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
	public class Icecek
	{
		[Key]
		public int Id {  get; set; }
		public string? Ad { get; set; }
		public string? Skt { get; set; }
		public int Adet { get; set; }
		public Siparis Siparis { get; set; }
		public IcecekKategorileri IcecekKategorileri { get; set; }
    }
}
