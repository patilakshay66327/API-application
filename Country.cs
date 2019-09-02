using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{

    public class Country
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public long CountryPopulation { get; set; }

        public string CountryArea { get; set; }

        public int CountryEquityCapital { get; set; }

        public string CountryCapital { get; set; }

        public string CountryCurrency { get; set; }

        public Development development { get; set; }

        public List<string> CountryStates { get; set; }


        public static List<Country> GetCountryCollections()
        {

            List<Country> countryCollections = new List<Country>();

            countryCollections.Add(new Country
            {
                CountryID = 1,
                CountryName = "India",
                CountryArea = "Centeral Earth",
                CountryCapital = "Dehli",
                CountryCurrency = "rupee",
                CountryPopulation = 15425126621,
                CountryStates = new List<string>
                { "mahrashtra","UP","Gujrat","Kerala"},
                CountryEquityCapital = 150,
                development = Development.Developing
            });

            countryCollections.Add(new Country
            {
                CountryID = 2,
                CountryName = "USA",
                CountryArea = "Northan Earth",
                CountryCapital = "Washington D.C.",
                CountryCurrency = "US Dollar",
                CountryPopulation = 5000000,
                CountryStates = new List<string>
                { "california","florida","texas","New York"},
                CountryEquityCapital = 100,
                development = Development.Developed
            });

            countryCollections.Add(new Country
            {
                CountryID = 3,
                CountryName = "China",
                CountryArea = "Northan Earth",
                CountryCapital = "Beijing",
                CountryCurrency = "Renminbi",
                CountryPopulation = 15420000,
                CountryStates = new List<string>
                { "Sicuan","Hainan","Jihansu","Henan"},
                CountryEquityCapital = 110,
                development = Development.Developed
            });

            countryCollections.Add(new Country
            {
                CountryID = 4,
                CountryName = "Russia",
                CountryArea = "Northan Earth",
                CountryCapital = "Moscow",
                CountryCurrency = "Rubel",
                CountryPopulation = 15410000,
                CountryStates = new List<string>
                { "Abdulino","Achinsk","Bobrov","Bolokhovo"},
                CountryEquityCapital = 115,
                development = Development.Developed
            });

            countryCollections.Add(new Country
            {
                CountryID = 5,
                CountryName = "South Africa",
                CountryArea = "Sothern Earth",
                CountryCapital = "Cape Town",
                CountryCurrency = "rand",
                CountryPopulation = 12000000,
                CountryStates = new List<string>
                { "BloemFontein","Lesotho","Durban","Pretoria"},
                CountryEquityCapital = 105,
                development = Development.UnderDeveloped
            });

            return countryCollections;
        }
    }
}


public enum Development
{
    UnderDeveloped,
    Developing,
    Developed
}
