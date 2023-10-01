using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class YemekDurum
    {
        [Key]
        public int Id { get; set; }
        public string Durum { get; set; }
    }
}
