using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entity
{
    public class Role
    {
        public Role()
        {
            Person = new HashSet<Person>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
