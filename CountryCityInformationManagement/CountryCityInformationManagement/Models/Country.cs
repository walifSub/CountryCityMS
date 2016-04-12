using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.Models
{
    public class Country
    {
        private string countryName;
        private string aboutCountry;
        //private int serialNo;
        private int id;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Country()
        { 
        } 

        public Country(int id, string countryName, string aboutCountry)
        {
            this.id = id;
            this.countryName = countryName;
            this.aboutCountry = aboutCountry;
        }
    }
}