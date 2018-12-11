namespace BusTicket.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tickets
    {
        public int ID { get; set; }

        public int? Staff_ID { get; set; }

        public int? Bus_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? Person_ID { get; set; }

        public int? Route_ID { get; set; }

        public int? TimeSlot_ID { get; set; }

        public virtual Buses Buses { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }

        public virtual Routes Routes { get; set; }

        public virtual TimeSlots TimeSlots { get; set; }
    }
}
