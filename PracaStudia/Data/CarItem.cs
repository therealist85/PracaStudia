using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracaStudia.Data
{
    [Table("car_items")]
    
    public class CarItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Model { get; set; }
        [MaxLength(17)]
        public int VIN { get; set; }
        [MaxLength(4)]
        public int Year {  get; set; }
    }
}
