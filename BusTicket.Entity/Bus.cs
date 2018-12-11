using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public class Bus
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string Plate { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(100)]
        public string NumberofSeat { get; set; }

        public bool CoupleSeat { get; set; }

        public bool IsAvailable { get; set; }

        public virtual ICollection<Seat> Seat { get; set; }

        public virtual ICollection<Route> Route { get; set; }

        public virtual ICollection<TimeSlot> TimeSlot { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }

        public Bus()
        {
            Seat = new HashSet<Seat>();
            Route = new HashSet<Route>();
            TimeSlot = new HashSet<TimeSlot>();
            Ticket = new HashSet<Ticket>();

        }

    }
}
