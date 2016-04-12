using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.Models
{
    public class CityView
    {
        private string countryName;
        private string aboutCountry;
        private string cityName;
        private string aboutCity;
        private int noOfDwellers;
        private int noOfCities;
        private string location;
        private string weather;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public string AboutCountry
        {
            get { return aboutCountry; }
            set { aboutCountry = value; }
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
        public int NoOfDwellers
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

        public CityView()
        {
        }

        public CityView(string countryName,string aboutCounry,string cityName, string aboutCity, int dwellers, string location, string weather)
        {
            this.countryName = countryName;
            this.aboutCountry = aboutCounry;
            this.cityName = cityName;
            this.aboutCity = aboutCity;
            this.noOfDwellers = dwellers;
            this.location = location;
            this.weather = weather;

        }

    }
}