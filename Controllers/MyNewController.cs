using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class MyNewController : ApiController
    {
        public List<Country> GetCountry()
        {
            //long maxPopulaation = Country.GetCountryCollections().Max(x => x.CountryPopulation);
            return Country.GetCountryCollections();
            //return Country.GetCountryCollections().Max(x => x.CountryPopulation);
        }

        public Country GetCountryById(int id)
        {
            return Country.GetCountryCollections().FirstOrDefault(x => x.CountryID == id);
        }

        public  Country Post([FromBody]Country country)
        {
            var results =  Country.GetCountryCollections();
            results.Add(country);

            return results.FirstOrDefault(x => x.CountryID == country.CountryID);
        }

    }
}
