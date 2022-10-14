using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;

namespace BackEnd.Models
{
    public class Ms_Storage_Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(10)]
        public string location_id { get; set; }
        [StringLength(100)]
        public string location_name { get; set; }
    }
}
