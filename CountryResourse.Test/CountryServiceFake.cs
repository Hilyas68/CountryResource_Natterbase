using CountryResource.DomainModels;
using CountryResource.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryResourse.Test
{
    class CountryServiceFake : ICountryRepository
    {
        private readonly List<CountryModel> countries;

        public CountryServiceFake()
        {
            countries = new List<CountryModel>()
            {
                new CountryModel {CountryId = 1 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"},
                new CountryModel {CountryId = 2 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"},
                new CountryModel {CountryId = 3 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"},
                new CountryModel {CountryId = 4 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"},
                new CountryModel {CountryId = 5 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"},
                new CountryModel {CountryId = 6 , Continent = "Africa", DateCreated = DateTime.Now, Name = "Nigeria"}
            };

        }

        public async Task<CountryModel> AddCountry(CountryModel country)
        {
            country.CountryId = countries.Max(c => c.CountryId) + 1;

             countries.Add(country);

            return country;
        }

        public Task<CountryModel> DeleteCountry(int countryid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryModel>> GetAllCountries()
        {
            return  countries;
        }

        public async Task<CountryModel> GetCountry(int countryid)
        {
            return countries.Find(c => c.CountryId == countryid);
        }

        public Task<CountryModel> UpdateCountry(CountryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
