using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
	public class IcecekKategorileri
	{
		[Key]
		public int Id { get; set; }
		public string Kategoriler { get; set; }
		public Icecek Icecek { get; set; }

    }
}
