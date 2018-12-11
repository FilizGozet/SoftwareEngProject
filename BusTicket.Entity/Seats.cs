namespace BusTicket.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeatNumber { get; set; }

        public bool SeatPlace { get; set; }

        public int? Bus_ID { get; set; }

        public virtual Buses Buses { get; set; }
    }
}
