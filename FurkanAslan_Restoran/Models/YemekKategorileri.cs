using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
	public class YemekKategorileri
	{
		[Key]
		public int Id { get; set; }
		public string Kategoriler{ get; set; }
		public Yemek Yemek { get; set; }
	}
}
