namespace AddressBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactAddress
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        public int AddressId { get; set; }

        public byte AddressType { get; set; }

        //public virtual Address Address { get; set; }

        //public virtual Contact Contact { get; set; }
    }
}
