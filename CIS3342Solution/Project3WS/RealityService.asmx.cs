using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using Utilities;
using System.Collections;
using MLSLibrary;

namespace Project3WS
{
    /// <summary>
    /// Summary description for RealityService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RealityService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetHomes()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Home";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public DataSet GetHouseCities()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT DISTINCT City FROM Home";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public DataSet GetHouseStates()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT DISTINCT State FROM Home";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public DataSet GetHouseTypes()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT DISTINCT Type FROM Home";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public DataSet GetHomesByPreference(String strSQL)
        {
            DBConnect objDB = new DBConnect();
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public DataSet GetRealtors()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Realtor";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }


        [WebMethod]
        public DataSet GetRealtorsListings(String realtorId)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Home Where RealtorId =" +realtorId + ";";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }


        [WebMethod]
        public bool UpdateRealtor(String strSQL)
        {
            DBConnect objDB = new DBConnect();
            if (objDB.DoUpdate(strSQL) <=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [WebMethod]
        public DataSet GetListingRequests(String realtorId)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM HomeShowingRequests WHERE RealtorId =" + realtorId + ";";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public String AddRealtor(String name, String company, String phone)
        {
            DBConnect objDB = new DBConnect();
            Random rnd = new Random();
            int id = rnd.Next(00000, 99999);
            String strSQL = "INSERT INTO Realtor (Id, Name, Company, PhoneNum) VALUES (" + id+ ", '" + name+ "', '" + company+"', '" +phone+ "')";
            if (objDB.DoUpdate(strSQL) <= 0)
            {
                return "Failure to Add realtor";
            }
            else
            {
                return "Realtor ID: " + id;
            }
        }

        [WebMethod]
        public String DeleteRealtor(String realtorId)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "DELETE * FROM Realtor WHERE Id =" + realtorId + ";";
            objDB.GetDataSet(strSQL);
            if (objDB.DoUpdate(strSQL) <= 0)
            {
                return "Failure to Delete Realtor";
            }
            else
            {
                return "Realtor Deleted Successfully";
            }
        }

        [WebMethod]
        public String AddHome(String realtorId, String address, String city, String state, String listPrice, String avail, String sqft, String baths, String beds, String type)
        {
            DBConnect objDB = new DBConnect();
            Random rnd = new Random();
            int id = rnd.Next(00000, 99999);
            String strSQL = "INSERT INTO Home (Id, Address, City, State, ListingPrice, SquareFeet, Availability, Beds, Baths, RealtorId, Type) VALUES (" + id + ", '" + address + "', '" + city + "', '" + state + "', " +listPrice+ ", " + sqft + ", '" + avail +"', " +beds+", " +baths+ ", "+realtorId+ ", '"+type +"')";
            if (objDB.DoUpdate(strSQL) < 0)
            {
                return "Failure to Add Home";
            }
            else
            {
                return "Home ID: " + id;
            }
        }

        [WebMethod]
        public String DeleteHome(String homeId)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "DELETE * FROM Home WHERE Id =" + homeId + ";";
            objDB.GetDataSet(strSQL);
            if (objDB.DoUpdate(strSQL) <= 0)
            {
                return "Failure to Delete Home";
            }
            else
            {
                return "Home Deleted Successfully";
            }
        }

        [WebMethod]
        public bool UpdateHome(String strSQL)
        {
            DBConnect objDB = new DBConnect();
            if (objDB.DoUpdate(strSQL) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [WebMethod]
        public String HomeViewRequest(String realtorId, String homeId, String name, String phone)
        {
            DBConnect objDB = new DBConnect();
            Random rnd = new Random();
            int id = rnd.Next(00000, 99999);
            String strSQL = "INSERT INTO HomeShowingRequests (Id, RealtorId, HomeId, ClientName, ClientPhone) VALUES (" + id + ", " + realtorId + ", " + homeId + ", '" + name + "', '" +phone+"');";
            if (objDB.DoUpdate(strSQL) <= 0)
            {
                return strSQL;
            }
            else
            {
                return strSQL;
            }
        }
    }
}
