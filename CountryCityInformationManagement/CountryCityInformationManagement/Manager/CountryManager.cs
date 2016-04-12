using CountryCityInformationManagement.DAL;
using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityInformationManagement.UI;

namespace CountryCityInformationManagement.Manager
{
    public class CountryManager
    {

        CountryGateWay gateWay = new CountryGateWay();
        
        public string Save(Country country)
        {
            string message;
            if (IsNotEmpty(country))
            {
                bool nameExist = gateWay.IsNameExist(country.CountryName);
                if (nameExist)
                {
                    message = "Country name already Exist!!";
                }
                else
                {
                    int rowAffected = gateWay.Insert(country);
                    if (rowAffected > 0)
                    {
                        message = "Saved Succefully!!";
                    }

                    else
                        message = "Insert Failed!!";
                }
            }
            else
            {
                message = "Field can't be empty";
            }
            return message;                        
        }

        public List<Country> GetAllCountryInfo()
        {
            List<Country> countries = gateWay.GetAllCountry();
            return countries;
        }

        public List<CountryViews> GetCountryByName(string countryName)
        {
            List<CountryViews> countryViewList = gateWay.SearchByCountryName(countryName);
            return countryViewList;
        }

        public List<CountryViews> GetAllCountry()
        {
            List<CountryViews> countryViewList = gateWay.ShowAllCountry();
            return countryViewList;
        }

        public bool IsNotEmpty(Country country)
        {
            if (country.CountryName != null && country.AboutCountry != null && country.CountryName != "" &&
                country.AboutCountry != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}