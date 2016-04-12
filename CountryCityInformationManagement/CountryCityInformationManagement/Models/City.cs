using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.Models
{
    public class City
    {
        private int id;
        private string cityName;
        private string aboutCity;
        private string noOfDwellers;
        private string location;
        private string weather;
        private int countryId;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        public string About
        {
            get { return aboutCity; }
            set { aboutCity = value; }
        }
        public string NoOfDwellers
        {
            get { return noOfDwellers; }
            set { noOfDwellers = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Weather
        {
            get { return weather; }
            set { weather = value; }
        }

        public int CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }
        public City(int id, string name, string about, string dwellers, string location, string weather, int countryId)
        {
            Id = id;
            CityName = name;
            About = about;
            NoOfDwellers = dwellers;
            Location = location;
            Weather = weather;
            CountryId = countryId;

        }

        public City()
        {

        }
    }
}