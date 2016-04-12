using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.DAL
{
    public class CityGetWay
    {
        string connectionString = @"Server=(local)\SQLEXPRESS;Database=CountryCityInfo;Integrated Security=true;";

        public int Insert(City city)
        {
            string query = "Insert into City(Name,About,NoOfdwellers,Location,Weather,CountryId) " +
                           "values(@cityName,@cityAbout,@noOfDwellers,@location,@weather,@countryId)";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            
            command.Parameters.Clear();
            command.Parameters.Add("cityName", SqlDbType.VarChar);
            command.Parameters["cityName"].Value = city.CityName;
            command.Parameters.Add("cityAbout", SqlDbType.VarChar);
            command.Parameters["cityAbout"].Value = city.About;
            command.Parameters.Add("noOfDwellers", SqlDbType.Int);
            command.Parameters["noOfDwellers"].Value = city.NoOfDwellers;
            command.Parameters.Add("location", SqlDbType.VarChar);
            command.Parameters["location"].Value = city.Location;
            command.Parameters.Add("weather", SqlDbType.VarChar);
            command.Parameters["weather"].Value = city.Weather;
            command.Parameters.Add("countryId", SqlDbType.Int);
            command.Parameters["countryId"].Value = city.CountryId;

            int rowAffected = command.ExecuteNonQuery();
            
            connection.Close();
            return rowAffected;
        }



        public bool GetCityByName(string CityName)
        {
            bool nameExist = false;
            string query = "SELECT * FROM City WHERE Name = @cityName";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("cityName",SqlDbType.VarChar);
            command.Parameters["cityName"].Value = CityName;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                nameExist = true;
            }
            return nameExist;
        }

        public List<CityView> GetAllInfoCity()
        {
            List<CityView> cities = new List<CityView>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from CityView ORDER BY CityName";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            CityView aNewCityView = null;
            while (reader.Read())
            {
                string cityname = reader["CityName"].ToString();
                int noOfDwellers = Convert.ToInt32(reader["NoOfdwellers"]);
                string country = reader["Country"].ToString();

                aNewCityView = new CityView();
                aNewCityView.CityName = cityname;
                aNewCityView.NoOfDwellers = noOfDwellers;
                aNewCityView.CountryName = country;

                cities.Add(aNewCityView);

            }
            connection.Close();
            return cities;
        }

        public List<CityView> ViewCity()
        {
            List<CityView> citiesView = new List<CityView>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CityView ORDER BY CityName";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CityView aNewCityView = null;

            while(reader.Read())
            {
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["About"].ToString();
                int noOfDwellers = Convert.ToInt32(reader["NoOfdwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string country = reader["Country"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                aNewCityView = new CityView(country,aboutCountry,cityName,aboutCity,noOfDwellers,location,weather);
                citiesView.Add(aNewCityView);
            }
            connection.Close();
            return citiesView;
        }
        public List<CityView> SearchByCityName(string cityKeyword)
        {
            List<CityView> citiesView = new List<CityView>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CityView WHERE CityName LIKE '%'+ @cityKeyword +'%'";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.Add("@cityKeyword", SqlDbType.VarChar);
            command.Parameters["@cityKeyword"].Value = cityKeyword;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CityView aNewCityView = null;

            while (reader.Read())
            {
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["About"].ToString();
                int noOfDwellers = Convert.ToInt32(reader["NoOfdwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string country = reader["Country"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                aNewCityView = new CityView(country, aboutCountry, cityName, aboutCity, noOfDwellers, location, weather);
                citiesView.Add(aNewCityView);
            }
            connection.Close();
            return citiesView;
        }

        internal List<CityView> SearchByCountryName(string countryName)
        {
            List<CityView> citiesView = new List<CityView>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CityView WHERE Country LIKE '%' + @countryName + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("@countryName", SqlDbType.VarChar);
            command.Parameters["@countryName"].Value = countryName;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CityView aNewCityView = null;

            while (reader.Read())
            {
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["About"].ToString();
                int noOfDwellers = Convert.ToInt32(reader["NoOfdwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string country = reader["Country"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                aNewCityView = new CityView(country, aboutCountry, cityName, aboutCity, noOfDwellers, location, weather);
                citiesView.Add(aNewCityView);
            }
            connection.Close();
            return citiesView;
        }
    }
}