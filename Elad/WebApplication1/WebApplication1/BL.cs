using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class BL
    {
        DAL dal = new DAL();
        private bool ValidationNameStreet(string NameStreet)
        {
            if (string.IsNullOrEmpty(NameStreet) == true)
                return false;
            else
            {
                bool isLetter = IsLetter(NameStreet);
                if (isLetter == false)
                    return false;
                else
                {
                    //todo
                }
            }
            return true;
        }
        private bool ValidationNameCity(string NameCity)
        {
            if (string.IsNullOrEmpty(NameCity) == true)
                return false;
            else
            {
                bool isLetter = IsLetter(NameCity);
                if (isLetter == false)
                    return false;
            }
            return true;
        }
        private bool IsLetter(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public string CreateCity(string NameCity)
        {
            bool IsValidationNameCity = ValidationNameCity(NameCity);
            if (IsValidationNameCity == true)
                dal.CreateCity(NameCity);
            else
              return  "not valid";
            return string.Empty;
        }
        public string CreateStreet(string NameStreet, string NameCity)
        {
            bool IsValidationNameStreet = ValidationNameCity(NameStreet);
            if (IsValidationNameStreet == true)
                dal.CreateStreet(NameStreet,NameCity);
            else
                return "not valid";
            return string.Empty;
        }
        public string DeleteCity(string NameCity)
        {
            bool IsValidationNameCity = ValidationNameCity(NameCity);
            if (IsValidationNameCity == true)
                dal.DeleteCity(NameCity);
            else
                return "not valid";
            return string.Empty;
        }
        public List<GetStreetsByCityId_Result> GetListStreetByCityId(int CityId)
        {
            List<GetStreetsByCityId_Result> list = dal.GetListStreetByCityId(CityId);
            return list;
        }
    }
}