using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public class TimeSlot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public TimeSpan TimeofDep { get; set; }

        public TimeSpan TimeofArr { get; set; }

        public virtual Bus Bus { get; set; }
    }
}
