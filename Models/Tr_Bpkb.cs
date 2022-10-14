using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Tr_Bpkb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(100)]
        public string agreement_number { get; set; }
        [StringLength(100)]
        public string bpkb_no { get; set; }
        [StringLength(10)]
        public string branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        [StringLength(100)]
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }
        [StringLength(10)]
        public string location_id  { get; set; }
        [StringLength(20)]
        public string police_no { get; set; }
        public DateTime bpkb_date_in { get; set; }


    }
}
