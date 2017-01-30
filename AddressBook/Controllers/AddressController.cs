using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AddressBook.Controllers
{
    public class AddressController : ApiController
    {
        ContactsDBContext dbContext = new ContactsDBContext();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public List<Address> Get(int id)
        {
            var contact = dbContext.Contacts.SingleOrDefault(c => c.Id == id);
            if (contact != null)
            {
                var addresses = (from item in contact.ContactAddresses
                                 select dbContext.Addresses.SingleOrDefault(a => a.Id == item.AddressId)).ToList<Address>();
                return addresses;
            }
            return null;
        }
        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}