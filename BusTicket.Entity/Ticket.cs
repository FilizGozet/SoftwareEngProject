using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public class Ticket
    {
        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual Person Person { get; set; }

        public virtual Route Route { get; set; }

        public virtual TimeSlot TimeSlot { get; set; }

        public virtual Bus Bus { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
