using CountryCityInformationManagement.Manager;
using CountryCityInformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryCityInformationManagement.UI
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryManager manager = new CountryManager();
        Country country = new Country();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountry();                
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string message = "";
            country.CountryName = countryNameTextBox.Text;
            country.AboutCountry = countryAboutCkEditor.Text;
            message = "<div class='alert alert-success' role='alert'>" + manager.Save(country) + "</div>";
            messageLabel.Text = message;
            ClearTexts();
            LoadCountry();
        }
        public void ClearTexts()
        {
            countryNameTextBox.Text = "";
            countryAboutCkEditor.Text = "";
        }

        public void LoadCountry()
        {            
            List<Country> countries = manager.GetAllCountryInfo();         
            countryGridView.DataSource = countries;
            countryGridView.DataBind();
        }
    }
}