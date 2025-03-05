using System;
using System.Data;
using DriversDataAccessLayer;

namespace DriversBusinessLayer
{
    public class clsCountryBusinessLayer
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CountryID { set; get; }
        public string CountryName { set; get; }
   

        public clsCountryBusinessLayer()
        {
            this.CountryID = -1;
            this.CountryName = "";

            Mode = enMode.AddNew;

        }

        private clsCountryBusinessLayer(int CountryID, string CountryName)

        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
  
            Mode = enMode.Update;

        }


        private bool _AddNewCountry()
        {
            //call DataAccess Layer 

            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName);

            return (this.CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            //call DataAccess Layer 

            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.CountryName);

        }

        public static clsCountryBusinessLayer Find(int ID)
        {

            string CountryName = "";
           
            int CountryID = -1;

            if (clsCountriesDataAccess.GetCountryInfoByID(ID, ref CountryName))

                return new clsCountryBusinessLayer(ID, CountryName);
            else
                return null;

        }

        public static clsCountryBusinessLayer Find(string CountryName)
        {

            int CountryID = -1;

            if (clsCountriesDataAccess.GetCountryInfoByName(CountryName, ref CountryID))

                return new clsCountryBusinessLayer(CountryID, CountryName);
            else
                return null;

        }


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountry();

            }




            return false;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();

        }

        public static bool DeleteCountry(int ID)
        {
            return clsCountriesDataAccess.DeleteCountry(ID);
        }

        public static bool isCountryExist(int ID)
        {
            return clsCountriesDataAccess.IsCountryExist(ID);
        }

        public static bool isCountryExist(string CountryName)
        {
            return clsCountriesDataAccess.IsCountryExist(CountryName);
        }


      

    }
}
