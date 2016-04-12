using CountryCityInformationManagement.Manager;
using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryCityInformationManagement.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadCountryDropdown();
            }
            LoadAllCity();
            messageLabel.Text = "";
        }
        private void LoadCountryDropdown()
        {
            List<Country> country = countryManager.GetAllCountryInfo();
            countryDropDownList.DataSource = country;
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
           
        }
        void LoadAllCity()
        {

            List<CityView> cities = cityManager.GetAllInfoCity();
            cityGridView.DataSource = cities;
            cityGridView.DataBind();
        }     
        

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City city = new City();
           
            city.CityName = nameTextBox.Text;
            city.About = aboutCkEditor.Text;
            city.NoOfDwellers = dwellersTextBox.Text;
            city.Location = locationTextBox.Text;
            city.Weather = weatherTextBox.Text;
            city.CountryId = Convert.ToInt32(countryDropDownList.SelectedValue);

            
            string message = "";
            CityManager manager = new CityManager();
            message = "<div class='alert alert-success' role='alert'>" + manager.Save(city)+ "</div>";
            messageLabel.Text = message;
            ClearText();
            LoadAllCity();

        }

        private void ClearText()
        {
            nameTextBox.Text = "";
            dwellersTextBox.Text = "";
            locationTextBox.Text = "";
            weatherTextBox.Text = "";
            aboutCkEditor.Text = "";
        }
    }
}
