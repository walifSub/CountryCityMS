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
    public partial class CountryView : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountry();
            }
        }

        protected void countrySearchButton_Click(object sender, EventArgs e)
        {
                string message = "";
                CountryViews countryViews = new CountryViews();
                countryViews.Name = countrySearchTextBox.Text;

                if (countryViews.Name != "")
                {
                    List<CountryViews> countryViewList = countryManager.GetCountryByName(countryViews.Name);
                    if (countryViewList.Count > 0)
                    {

                        countryViewGridView.DataSource = countryViewList;
                        countryViewGridView.DataBind();
                    }
                    else
                    {
                        message = "<div class='alert alert-danger' role='alert'>Sorry, we can't find " + countryViews.Name + " </div>";
                    }
                }
                messageLabel.Text = message;
                Clear();
                countryViewGridView.UseAccessibleHeader = true;
                countryViewGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        public void LoadCountry()
        {
            List<CountryViews> countryViewList = countryManager.GetAllCountry();
            countryViewGridView.DataSource = countryViewList;
            countryViewGridView.DataBind();

            countryViewGridView.UseAccessibleHeader = true;
            countryViewGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        public void Clear()
        {
            countrySearchTextBox.Text = "";
        }
    }
}