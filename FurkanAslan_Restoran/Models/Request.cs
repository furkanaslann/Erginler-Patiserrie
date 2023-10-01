using System.ComponentModel.DataAnnotations;

namespace FurkanAslan_Restoran.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
