using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;
using System.Data;

namespace CourseRegistrationLibrary
{
    public class RegistrationFunctions
    {
        public static string AddStudent(string name, string major)
        {
            Random rnd = new Random();
            double id = rnd.Next(000000000, 1000000000);
            DBConnect objDB = new DBConnect();
            String strSQL2 = "INSERT INTO Students (StudentID, Name, Major, TuitionOwed) VALUES (" + id + ", '" + name + "', '" + major + "', 0);";
            objDB.DoUpdate(strSQL2);
            return id.ToString();
        }

        public static void AddCourse(Course c)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "INSERT INTO Course VALUES ('" + c.Crn + "', '" + c.CourseTitle + "', '" + c.DepartmentId + "', '" + c.Section + "', '" + c.Professor + "', '" + c.DayCode + "', '" + c.TimeCode + "', '" + c.CreditHours + "', " + c.MaxSeats + ", " + c.MaxSeats + ");";
            //String strSQL = "INSERT INTO Course VALUES ('1G63', 'C Sharp' , 'CIS' , 'CIS42' , 'Pascucci' , 'Thursday' , '15:00' , '4.00' , 45 , 45);";
            objDB.DoUpdate(strSQL);
        }

        public static void AddDepartment(string id, string name, string location)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "INSERT INTO Department VALUES ('" + id + "', '" + name + "', '" + location + "');";
            objDB.DoUpdate(strSQL);
        }

        public static DataSet GetStudentRoster(string id)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT CourseRegistration.CRN, Course.CourseTitle, Course.DepartmentID, Course.Section, Course.Professor, Course.DayCode, Course.TimeCode, Course.CreditHours FROM CourseRegistration, Course WHERE CourseRegistration.StudentID LIKE '" + id + "' AND CourseRegistration.CRN LIKE Course.CRN;";
            DataSet myDS = objDB.GetDataSet(strSQL);
            return myDS;
        }

        public static DataSet GetTuition(string id)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT TuitionOwed FROM Students WHERE StudentID LIKE '" + id + "';";
            DataSet myDS = objDB.GetDataSet(strSQL);
 
            return myDS;
            
        }

        public static string RegisterClasses(ArrayList classes, string studID, double tuition)
        {
            String status = "";
            foreach(RegClass reg in classes)
            {
                
                Random rnd = new Random();
                int regNum = rnd.Next(000000000, 1000000000);
                DBConnect objDB = new DBConnect();
                String strSQL = "IF NOT EXISTS (SELECT * FROM CourseRegistration WHERE CRN LIKE '" + reg.Crn + "' AND StudentID LIKE '" + studID + "') INSERT INTO CourseRegistration (RegistrationNumber, StudentID, CRN) VALUES ('" + regNum + "', '" + studID + "', '" + reg.Crn + "');";
                if (objDB.DoUpdate(strSQL) > 0)
                {
                    String strSQL2 = "UPDATE Course SET NumberSeatsAvailable = (NumberSeatsAvailable-1) WHERE CRN LIKE '" + reg.Crn + "';";
                    objDB.DoUpdate(strSQL2);
                    String strSQL3 = "UPDATE Students SET TuitionOwed = (TuitionOwed+" + tuition + ") WHERE StudentID LIKE '" + studID + "';";
                    objDB.DoUpdate(strSQL3);
                    status = "REGISTRATION SUCCESSFUL";
                }
                else
                {
                    status = "YOU HAVE ALREADY REGISTERED THIS COURSE";
                }
            }
            return status;
        }

        public static void DeleteCourse(String CRN)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "DELETE FROM Course WHERE CRN LIKE '" + CRN + "';";
            objDB.DoUpdate(strSQL);
            strSQL = "DELETE FROM CourseRegistration WHERE CRN LIKE '" + CRN + "';";
            objDB.DoUpdate(strSQL);
        }

       
    }
}
