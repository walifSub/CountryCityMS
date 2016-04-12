using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityInformationManagement.Manager;
using CountryCityInformationManagement.Models;

namespace CountryCityInformationManagement.UI
{
    public partial class ViewCities : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadCountry();
            }
            LoadCityWithCountryInfo();
        }

        private void LoadCityWithCountryInfo()
        {
            cityViewGridView.DataSource = cityManager.ViewCity();
            cityViewGridView.DataBind();

            cityViewGridView.UseAccessibleHeader = true;
            cityViewGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        private void LoadCountry()
        {
            List<Country> countries = new List<Country>();
            countries = countryManager.GetAllCountryInfo();
            countryDropDownList.DataSource = countries;
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string message = "";
            cityNameTextBox.Enabled = true;

            if(cityNameRadioButton.Checked)
            {
                if(cityNameTextBox.Text != "")
                {
                    string cityKeyword = cityNameTextBox.Text;

                    List<CityView> citiesView = cityManager.SearchByCityName(cityKeyword);
                    if (citiesView.Count > 0)
                    {
                        cityViewGridView.DataSource = citiesView;
                        cityViewGridView.DataBind();
                    }
                    else
                    {
                        message = "<div class='alert alert-danger' role='alert'>Sorry, we can't find " + cityKeyword  + " </div>";
                    }
                }
            }
            else if (countryNameRadioButton.Checked)
            {
                string countryName = countryDropDownList.SelectedItem.Text;
                List<CityView> citiesView = cityManager.SearchByCountryName(countryName);
                if (citiesView.Count > 0)
                {
                    cityViewGridView.DataSource = citiesView;
                    cityViewGridView.DataBind();
                }
                else
                {
                    message = "<div class='alert alert-success' role='alert'>Sorry, we can't find " + countryName + " </div>";
                }
            }
            messageLabel.Text = message;
            cityViewGridView.UseAccessibleHeader = true;
            cityViewGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}