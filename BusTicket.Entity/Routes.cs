namespace BusTicket.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Routes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Routes()
        {
            Tickets = new HashSet<Tickets>();
            Buses = new HashSet<Buses>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ToWhere { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        [Required]
        [StringLength(100)]
        public string FromWhere { get; set; }

        public int? UstID { get; set; }

        public TimeSpan AppTimeInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buses> Buses { get; set; }
    }
}
