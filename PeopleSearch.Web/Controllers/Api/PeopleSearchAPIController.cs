using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using PeopleSearch.EF;
using PeopleSearch.Web.Models;
using Newtonsoft.Json;

namespace PeopleSearch.Web.Controllers.Api
{
    [RoutePrefix("api/PeopleSearch")]
    public class PeopleSearchAPIController : ApiController
    {
        public class SearchParams
        {
            public string searchString { get; set; }
        }

        // GET: api/PeopleSearch
        [HttpGet]
        [Route("")]
        //public IEnumerable<Person> getPersons([FromBody]SearchParams param)
        public IEnumerable<Person> getPersons(string searchString)
        {
            IEnumerable<Person> ret = null;

            searchString = JsonConvert.DeserializeObject<string>(searchString);

            //searchString = searchString.Replace('\\\','');

            try
            {
                using (var db = new PeopleDB())
                {                   
                    ret = db.GetPersonsBySearch(searchString)
                    .Select(p => new Person
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        Age = p.Age,
                        Address = p.Address,
                        Interests = p.Interests,                           
                        Picture = p.Picture
                    })
                    .ToList();
                    
                    return ret;
                }
            }
            catch (Exception ex)
            {
                throw ex;               
            }
        }
     }
}