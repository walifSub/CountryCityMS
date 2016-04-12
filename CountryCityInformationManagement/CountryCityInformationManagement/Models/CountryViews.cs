using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace CountryCityInformationManagement.Models
{
    public class CountryViews
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string about;

        public string About
        {
            get { return about; }
            set { about = value; }
        }

        private int noOfCities;

        public int NoOfCities
        {
            get { return noOfCities; }
            set { noOfCities = value; }
        }

        private int noOfDwellers;

        public int NoOfDwellers
        {
            get { return noOfDwellers; }
            set { noOfDwellers = value; }
        }
    }
}