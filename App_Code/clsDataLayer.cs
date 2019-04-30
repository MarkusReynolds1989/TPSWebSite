//Data Layer Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.Data;

namespace TPS.App_Code
{
    public class clsDataLayer
    {
        /* Adding to database codes
             //////////////////////////
             ////////////////////////*/

        /*Approve a contract Manager only
        ///////////////////////////
        ///////////////////////*/
        public static bool ApproveRequest(string Database, string RequestID)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblContract (RequestID)" + "values ('" +
                    RequestID + "')";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }


        /*Add a new User Admin only
        ////////////////////
        ///////////////////*/
        public static bool AddUser(string Database, string UserName, string UserPassword, int AccessLevel)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblUserAccess (UserName, UserPassword, SecurityLevel)" + "values ('" + UserName + "','"
                    + UserPassword + "','" + AccessLevel + "' )";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /*Add staff member Staff Only
        ////////////////////
        ///////////////////*/
        public static bool SaveStaff(string Database, string FirstName, string LastName, string EduLevel, string Experience, string Salary,string Location)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblStaffMember (FirstName ,LastName ,EduLevel,Experience,Salary,Location) "
                    + "values ('" + FirstName + "','"
                    + LastName + "','"
                    + EduLevel + "','" + Experience + "','" + Salary + "','" + Location + "' ) ";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /*Add A Staff Request Only Client
        ////////////////////
        ///////////////////*/
        public static bool SaveStaffRequest(string Database, string StaffID1, string StaffID2, string StaffID3)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblStaffRequest (StaffID1 ,StaffID2 ,StaffID3) "
                    + "values ('" + StaffID1 + "','"
                    + StaffID2 + "','"
                    + StaffID3 + "' ) ";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /*Add staff profile info Only Staff
        ////////////////////
        ///////////////////*/
        public static bool UpdateStaffPortal(string Database, string Bio, string Availability, string Resume, string Picture)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblStaffProfile(Bio ,Availability ,Resume, Picture) "
                    + "values ('" + Bio + "','"
                    + Availability + "','"
                    + Resume + "','" + Picture + "' ) ";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /* Delete from tables
        /////////////////////
        ///////////////////*/


        /*Delete Staff Member Only Admin 
        ////////////////////
        ///////////////////*/
        public static bool DeleteStaff(string Database, string MemberID)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Delete from tblStaffMember where MemberID =" + MemberID;
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /* Delete User Manager Only
        ////////////////////
        //////////////////*/

        public static bool DeleteUser(string Database, string UserID)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Delete from tblUserAccess where UserId=" + UserID;
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /* Deny Contract Manager Only
        ////////////////////
        //////////////////*/

        public static bool DeleteRequest(string Database, string RequestID)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Delete from tblStaffRequest where RequestID =" + RequestID;
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /* Delete Contract Only Admin
        //////////////////////////
        ////////////////////////*/
        ///
        public static bool DeleteContract(string Database, string ContractID)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Delete from tblContract where ContractID =" + ContractID;
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /*Updates
        /////////////////
        ///////////////*/

        /*Update Staff///////
        ////////////////////
        ///////////////////*/

        public static bool UpdateStaff(string Database, string MemberID, string FirstName, string LastName, string EduLevel, string Experience, string Salary,string Location)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Update tblStaffMember Set FirstName = '"
                    + FirstName + "' , LastName = '" + LastName
                    + "' , EduLevel = '" + EduLevel + "' , Experience = '" + Experience
                    + "' , Salary ='" + Salary + "', Location ='" + Location + "' where MemberID = " + MemberID + "";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }

        /*Update User///////
        ////////////////////
        ///////////////////*/
        public static bool UpdateUser(string Database, string UserId, string UserName, string UserPassword, int SecurityLevel)
        {
            bool recordSaved;
            SqlTransaction myTransaction = null;
            try
            {
                SqlConnection conn = new SqlConnection(
                    "Data Source=" + Database);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Update tblUserAccess set UserName = '" + UserName
                    + "' , UserPassword = '" + UserPassword + "' , SecurityLevel = '" + SecurityLevel
                    + "' where UserId = " + UserId + "";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                myTransaction.Commit();
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }







        /*Fills
        //////////////////
        /////////////////*/

        /*Fill staff table
        ////////////////////
        ///////////////////*/
        public static dsStaff AccessStaff(string Database)
        {
            dsStaff DS;
            //we call objects of the classes
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblStaffMember", sqlConn); //How can we display salary as $
            //new object of the DS class
            DS = new dsStaff();
            // method of sqlDA class to fill the table
            sqlDA.Fill(DS.tblStaffMember);
            return DS;
        }

        /*Fill Contracts table
        ////////////////////
        ///////////////////*/
        public static dsContracts AccessContracts(string Database)
        {
            dsContracts DS;
            //we call objects of the classes
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblContract", sqlConn); //How can we display salary as $
            //new object of the DS class
            DS = new dsContracts();
            // method of sqlDA class to fill the table
            sqlDA.Fill(DS.tblContract);
            return DS;
        }

        /*Fill Manager Table
        ////////////////////
        ///////////////////*/
        public static dsManager AccessManager(string Database)
        {
            dsManager DS;
            //Call objects
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblManager", sqlConn);
            //datastream class 
            DS = new dsManager();
            //fill table
            sqlDA.Fill(DS.tblManager);
            return DS;
        }

        /*Fill Client Table
        ////////////////////
        ///////////////////*/
        public static dsClient AccessClient(string Database)
        {
            dsClient DS;
            //Call Objects
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblClient", sqlConn);
            //datastream class
            DS = new dsClient();
            //fill table
            sqlDA.Fill(DS.tblClient);
            return DS;
        }

        /*Fill Users table
        ////////////////////
        ///////////////////*/
        public static dsUserAccess AccessUsers(string Database)
        {
            dsUserAccess DS;
            //Call Objects
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblUserAccess", sqlConn);
            //datastream class
            DS = new dsUserAccess();
            //fill table
            sqlDA.Fill(DS.tblUserAccess);
            return DS;
        }

        /* Fill Staff Requests Table
        ////////////////////////////
        //////////////////////////*/
        public static dsStaffRequest AccessStaffRequests(string Database)
        {
            dsStaffRequest DS;
            //Call Objects
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblStaffRequest", sqlConn);
            //datastream class
            DS = new dsStaffRequest();
            //fill table
            sqlDA.Fill(DS.tblStaffRequest);
            return DS;
        }


        /* Fill Staff Profile
        //////////////////
        ////////////////*/
        public static dsStaffProfile AccessStaffProfile(string Database)
        {
            dsStaffProfile DS;
            //Call Objectshg
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new SqlConnection("Data Source =" + Database);
            sqlDA = new SqlDataAdapter("select * from tblStaffProfile", sqlConn);
            //datastream class
            DS = new dsStaffProfile();
            //fill table
            sqlDA.Fill(DS.tblStaffProfile);
            return DS;
        }

        /* Special Methods
        //////////////////
        ////////////////*/

        /*Search Through Staff for staffrequest
        ////////////////////////////
        /////////////////////////*/
        //We only want them to be able to select three staff members, they can search by 
        //Exp, edu, salary, and location

        public static dsStaff SearchStaff(string Database, string Experience, string Education, string Salary, string Location)
        {
            dsStaff DS;
            //we call objects of the classes
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new SqlConnection("Data Source =" + Database);
            if (Experience != null || Experience.Trim() != "" && Education != null || Education.Trim() != ""
                && Salary != null || Salary.Trim() != "" && Location != null || Location.Trim() != "")
            {
                sqlDA = new SqlDataAdapter("select * from tblStaffMember where Experience like '%" +
                    Experience + "%' and EduLevel like '%" + Education + "%' and Salary like '%" +
                    Salary + "%' and Location like '%" + Location + "%'", sqlConn);
            }
            else
            {
                sqlDA = new SqlDataAdapter("select * from tblStaffMember", sqlConn);
            }
            //new object of the DS class
            DS = new dsStaff();
            // method of sqlDA class to fill the table
            sqlDA.Fill(DS.tblStaffMember);
            return DS;
        }

        /* Verify User login method
        ///////////////////////////
        /////////////////////////*/

        public static dsUserAccess VerifyUser(string Database, string UserName, string UserPassword)
        {
            dsUserAccess DS;
            SqlConnection sqlConn;
            SqlDataAdapter sqlDA;
            sqlConn = new SqlConnection(
            "Data Source=" + Database);
            sqlDA = new SqlDataAdapter("Select SecurityLevel from tblUserAccess " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            DS = new dsUserAccess();
            sqlDA.Fill(DS.tblUserAccess);
            return DS;
        }

    }
}


