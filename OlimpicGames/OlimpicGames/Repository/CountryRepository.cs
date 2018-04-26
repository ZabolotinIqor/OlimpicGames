using OlimpicGames.EntityFramework;
using OlimpicGames.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.Repository
{
    class CountryRepository
    {
        private OlimpicGameContext context;
        
        public IEnumerable<Country> getCountries()
        {
            return context.countries;
        }

        public Country getCountryById(int id)
        {
            return context.countries.Find(id);
        }

        public void deleteCountry(int id)
        {
            var country = context.countries.Find(id);
            context.countries.Remove(country);
        }

        public void updateCountry(Country country)
        {
            context.Entry(country).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }



    }
}
