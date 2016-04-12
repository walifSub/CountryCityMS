using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using CountryCityInformationManagement.UI;


namespace CountryCityInformationManagement.DAL
{
    public class CountryGateWay
    {
        string connectionString = @"Server=(local)\SQLEXPRESS;Database=CountryCityInfo;Integrated Security=true;";
      
        public bool IsNameExist(string countryName)
        {
            bool nameExist = false;

            string query = "SELECT * FROM Country WHERE Name = @countryName";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.Clear();
            command.Parameters.Add("countryName", SqlDbType.VarChar);
            command.Parameters["countryName"].Value = countryName;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                nameExist = true;
            }
            return nameExist;        
        }

        public int Insert(Country country)
        {                  
            string query = "Insert into Country (Name,About) values(@countryName,@countryAbout)";
            SqlConnection connection = new SqlConnection(connectionString);            
            connection.Open();

            SqlCommand command = new SqlCommand();            
            command.CommandText = query;
            command.Connection = connection;
            
            command.Parameters.Clear();
            command.Parameters.Add("countryName", SqlDbType.VarChar);
            command.Parameters["countryName"].Value = country.CountryName;
            command.Parameters.Add("countryAbout", SqlDbType.VarChar);
            command.Parameters["countryAbout"].Value = country.AboutCountry;

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;           
        }

        public List<Country> GetAllCountry()
        { 
            List<Country> countries = new List<Country>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from Country ORDER BY Name";
            connection.Open();

            SqlCommand command = new SqlCommand(query,connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {               
                Country aCountry = new Country();
                aCountry.Id = Convert.ToInt32(reader["Id"]);
                aCountry.CountryName = reader["Name"].ToString();
                aCountry.AboutCountry = reader["About"].ToString();                
                countries.Add(aCountry);               
            }
            connection.Close();
            return countries;
        }

        public List<CountryViews> SearchByCountryName(string countryName)
        {
            List<CountryViews> countryViewList = new List<CountryViews>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from CountryViews Where Name Like '%'+ @countryName+'%'";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("@countryName", SqlDbType.VarChar);
            command.Parameters["@countryName"].Value = countryName;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CountryViews countryViews = new CountryViews();
                countryViews.Name = reader["Name"].ToString();
                countryViews.About = reader["About"].ToString();
                countryViews.NoOfCities = Convert.ToInt32(reader["NoOfCities"]);
                countryViews.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"]);
                countryViewList.Add(countryViews);
            }
            connection.Close();
            return countryViewList;
        }

        public List<CountryViews> ShowAllCountry()
        {
            List<CountryViews> countryViewList = new List<CountryViews>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from CountryViews";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {                
                CountryViews countryViews = new CountryViews();
                countryViews.Name = reader["Name"].ToString();
                countryViews.About = reader["About"].ToString();              
                countryViews.NoOfCities = Convert.ToInt32(reader["NoOfCities"]);             
                countryViews.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"]);               
                countryViewList.Add(countryViews);
            }
            connection.Close();
            return countryViewList;
        }       
    }
}