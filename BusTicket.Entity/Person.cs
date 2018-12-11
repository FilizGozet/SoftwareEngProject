using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public abstract class Person
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string IdentificationNumber { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(80)]
        public string Phone { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }

        public Person(){

            Ticket = new HashSet<Ticket>();

        }

    }
}
