using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AddressBook.Controllers
{
    public class ContactsController : ApiController
    {
        ContactsDBContext dbContext = new ContactsDBContext();
        // GET api/contacts
        public List<Contact> Get()
        {            
            List<Contact> contacts = dbContext.Contacts.ToList();           
            return contacts;
        }

        // GET api/contacts/5
        public Contact Get(int id)
        {
            return dbContext.Contacts.SingleOrDefault(c=>c.Id==id);
        }

       

        // GET api/contacts/<FirstName>
        public string Get(string fName)
        {
            Contact searchedContact = dbContext.Contacts.Where(x => x.FirstName == fName).FirstOrDefault();
            return "value";
        }

        // POST api/contacts
        public void Post([FromBody]string value)
        {
        }

        // PUT api/contacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/contacts/5
        public void Delete(int id)
        {
        }
    }
}
