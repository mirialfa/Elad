using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DAL
    {
        EladEntities db = new EladEntities();
        public void CreateCity(string NameCity)
        {
            db.CreateCity(NameCity); 
        }
        public void CreateStreet(string NameStreet,string CityName)
        {
            db.CreateStreet(NameStreet,CityName);
        }
        public void DeleteCity(string NameCity)
        {
            db.DeleteCity(NameCity);
        }
        public List<GetStreetsByCityId_Result> GetListStreetByCityId(int CityId)
        {
            List<GetStreetsByCityId_Result>  list = db.GetStreetsByCityId(CityId).ToList();
            return list;
        }
    }
}