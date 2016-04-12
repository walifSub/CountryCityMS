using CountryCityInformationManagement.DAL;
using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.Manager
{
    public class CityManager
    {
        CityGetWay citygetway = new CityGetWay();
        public string Save(City city)
        {
            string message;

            if (city.CityName == "")
            {
                return message = "Name field ie required";
            }
            bool nameExist = citygetway.GetCityByName(city.CityName);

            if (nameExist)
            {
                message = "City name already Exists!!";
            }
            else
            {
                int rowAffected = citygetway.Insert(city);
                if (rowAffected > 0)
                {
                    message = "Saved Succefully!!";
                }

                else
                    message = "Insert Failed!!";
            }

            return message;
        }

        public List<CityView> GetAllInfoCity()
        {
            List<CityView> cities = citygetway.GetAllInfoCity();
            return cities;
        }

        public List<CityView> ViewCity()
        {
            List<CityView> citiesView = citygetway.ViewCity();
            return citiesView;
        }

        public List<CityView> SearchByCityName(string cityKeyword)
        {
            return citygetway.SearchByCityName(cityKeyword);
        }

        internal List<CityView> SearchByCountryName(string countryName)
        {
            return citygetway.SearchByCountryName(countryName);
        }
    }
}