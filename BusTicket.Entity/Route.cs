using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public class Route
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FromWhere { get; set; }

        [Required]
        [StringLength(100)]
        public string ToWhere { get; set; }

        public int? UstID { get; set; }

        public TimeSpan AppTimeInterval { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; } //oluşturulan küçük duraklar için fiyat verilir

        public virtual ICollection<Bus> Bus { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }

        public Route()
        {
            Bus = new HashSet<Bus>();
            Ticket = new HashSet<Ticket>();
        }


    }
}
