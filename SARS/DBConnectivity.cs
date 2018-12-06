using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace SARS
{
    public class DBConnectivity
    {
        private static OleDbConnection GetConnection()
        {
            string connString;
            //  change to your connection string in the following line
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\College\Degree Life\Sem 2\ISDP April 26\SARSPROJECT\Sars.accdb";
            return new OleDbConnection(connString);
        }

        #region Attendance
        //Lecturer
        public static void RecordAttendance(string sid, string sn, string ln, string sj, string day, string period, string status, string adate)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Attendance(SID, StudentName, Lecturer, [Subject], [Day], [Period], [Status], ADate) VALUES " +
                             "( '" + sid + "', '" + sn + "', '" + ln + "', '" + sj + "', '" + day + "', '" + period + "', '" + status + "', '" + adate + "' )";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        //Admin & Coordinator
        public static bool AccountLogin(string id, string pw)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Account WHERE Username = '" + id + "' AND Password = '" + pw + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        HttpContext.Current.Session["type"] = myReader["Type"].ToString();
                        HttpContext.Current.Session["userid"] = myReader["UID"].ToString();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void AddTimetable(string sjn, string day, string period, string cn)
        {
            OleDbConnection myConnection = GetConnection();

            OleDbCommand course;
            string coursecmd = "SELECT CourseName From Subject WHERE SJName = '" + sjn + "'";
            course = new OleDbCommand(coursecmd, myConnection);

            myConnection.Open();
            string courseName = Convert.ToString(course.ExecuteScalar());

            string myQuery = "INSERT INTO Timetable(SJName, [Day], [Period], [CourseName]) VALUES " +
                             "( '" + sjn + "', '" + day + "', '" + period + "', '" + courseName + "' )";

            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void AddSubject(string sjn, string cn)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Subject(SJName, CourseName) VALUES " +
                             "( '" + sjn + "', '" + cn + "')";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool ValidateSubject(string sjn)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Subject WHERE SJName = '" + sjn + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void AssignStudent(string sn, string tid)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Class(SID, TID) VALUES " +
                             "( " + sn + ", " + tid + ")";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool ValidateAssign(string sn, string tid)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Class WHERE SID = " + sn + " AND TID = " + tid + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void AddCoordinator(string un, string pw, string cn)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Account([Username], [Password], [Name], Type) VALUES " +
                             "( '" + un + "', '" + pw + "', '" + cn + "', 'coordinator' )";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void AddLecturer(string un, string pw, string ln, string cn)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Lecturer([Username], [Password], LName, CourseName, Type) VALUES " +
                             "( '" + un + "', '" + pw + "', '" + ln + "', '" + cn + "', 'lecturer' )";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void AddStudent(string un, string pw, string sn, string cn)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Student([Username], [Password], SName, CourseName, Type) VALUES " +
            "( '" + un + "', '" + pw + "', '" + sn + "', '" + cn + "', 'student' )";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        #endregion

        #region Login
        //Login

        public static bool ValidateUsername(string id)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Account WHERE Username = '" + id + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool ValidateLecturerUsername(string id)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Lecturer WHERE Username = '" + id + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool ValidateStudentUsername(string id)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Student WHERE Username = '" + id + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool Login(string id, string pw) {
        OleDbConnection myConnection = GetConnection();
        string myQuery = "SELECT * FROM Account WHERE Username = '" + id + "' AND Password = '" + pw + "'";
        OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

        try
        {
            myConnection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    HttpContext.Current.Session["type"] = myReader["Type"].ToString();
                    HttpContext.Current.Session["userid"] = myReader["UID"].ToString();
                    HttpContext.Current.Session["name"] = myReader["Name"].ToString();
                }
                return true;
            }
            else {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception in DBHandler", ex);
            return false;
        }
        finally
        {
            myConnection.Close();
        }
    }

        public static bool StudentLogin(string id, string pw)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Student WHERE Username = '" + id + "' AND Password = '" + pw + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        HttpContext.Current.Session["type"] = myReader["Type"].ToString();
                        HttpContext.Current.Session["userid"] = myReader["SID"].ToString();
                        HttpContext.Current.Session["name"] = myReader["SName"].ToString();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool LecturerLogin(string id, string pw)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Lecturer WHERE Username = '" + id + "' AND Password = '" + pw + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        HttpContext.Current.Session["type"] = myReader["Type"].ToString();
                        HttpContext.Current.Session["userid"] = myReader["LID"].ToString();
                        HttpContext.Current.Session["name"] = myReader["LName"].ToString();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        #endregion
    }
}
