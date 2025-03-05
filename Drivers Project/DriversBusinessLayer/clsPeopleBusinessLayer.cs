using System;
using System.Data;
using DriversDataAccessLayer;

namespace DriversBusinessLayer
{
    public class clsPeopleBusinessLayer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

       
        public clsPeopleBusinessLayer()

        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPeopleBusinessLayer(int PersonID, string NationalNo, string FirstName,
       string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
       int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }


        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,
                           this.LastName,this.DateOfBirth,this.Gender, this.Address, this.Phone, this.Email,
                                                            this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleDataAccess.UpdatePerson(this.PersonID ,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                           this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                                                            this.NationalityCountryID, this.ImagePath);

        }

        public static clsPeopleBusinessLayer Find(int PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = -1;
            string Address = "", Phone = "", Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";


            if (clsPeopleDataAccess.GetPeopleInfoByID(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))

                return new clsPeopleBusinessLayer(PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,
                    Gender,Address,Phone,Email,NationalityCountryID,ImagePath);
            else
                return null;
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }




            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();

        }


        public static bool DeletePerson(int ID)
        {
            return clsPeopleDataAccess.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPeopleDataAccess.IsPersonExist(ID);
        }



    }
}
