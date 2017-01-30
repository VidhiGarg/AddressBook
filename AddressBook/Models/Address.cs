namespace AddressBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            ContactAddresses = new HashSet<ContactAddress>();
        }

        public int Id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }

        [StringLength(100)]
        public string Line1 { get; set; }

        [StringLength(100)]
        public string Line2 { get; set; }

        [StringLength(100)]
        public string Line3 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string County { get; set; }

        [StringLength(20)]
        public string PostCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddress> ContactAddresses { get; set; }
    }
}
