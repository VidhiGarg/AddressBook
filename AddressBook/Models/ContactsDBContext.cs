namespace AddressBook.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactsDBContext : DbContext
    {
        public ContactsDBContext()
            : base("name=ContactsDBContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ContactAddress> ContactAddresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Version)
                .IsFixedLength();

            //modelBuilder.Entity<Address>()
            //    .HasMany(e => e.ContactAddresses)
            //    .WithRequired(e => e.Address)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.ContactAddresses)
                .WithRequired()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Version)
                .IsFixedLength();

            //modelBuilder.Entity<Contact>()
            //    .HasMany(e => e.ContactAddresses)
            //    .WithRequired(e => e.Contact)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactAddresses)
                .WithRequired()
                .WillCascadeOnDelete(false);
        }
    }
}
