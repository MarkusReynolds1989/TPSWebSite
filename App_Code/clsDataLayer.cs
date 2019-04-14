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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
        public static bool SaveUser(string Database, string UserName, string UserPassword, string AccessLevel)
        {
            bool recordSaved;
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
        public static bool SaveStaff(string Database, string FirstName, string LastName, string EduLevel, string Experience, string Salary, string Location)
        {
            bool recordSaved;
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblStaffMember (FirstName ,LastName ,EduLevel,Experience,Salary) "
                    + "values ('" + FirstName + "','"
                    + LastName + "','"
                    + EduLevel + "','" + Experience + "','" + Salary + "' ) ";
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
        public static bool UpdateStaffPortal(string Database, string Bio, string Avail, string Resume, string Picture)
        {
            bool recordSaved;
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Insert into tblStaffProfile(Bio ,Avail ,Resume, Picture) "
                    + "values ('" + Bio + "','"
                    + Avail + "','"
                    + Resume + "','" + Picture + ")'";
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Delete from tblContracts where ContractID =" + ContractID;
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
            OleDbTransaction myTransaction = null;
            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                strSQL = "Update tblStaffMember Set tblStaffMember FirstName = '"
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblStaffMember", sqlConn); //How can we display salary as $
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblContract", sqlConn); //How can we display salary as $
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblManager", sqlConn);
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblClient", sqlConn);
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblUserAccess", sqlConn);
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblStaffRequest", sqlConn);
            //datastream class
            DS = new dsStaffRequest();
            //fill table
            sqlDA.Fill(DS.tblStaffRequest);
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //we use the methods to create messages and connect to the database
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + Database);
            if (Experience != null || Experience.Trim() != "" && Education != null || Education.Trim() != ""
                && Salary != null || Salary.Trim() != "" && Location != null || Location.Trim() != "")
            {
                sqlDA = new OleDbDataAdapter("select * from tblStaffMember where Experience like '%" +
                    Experience + "%' and EduLevel like '%" + Education + "%' and Salary like '%" +
                    Salary + "%' and Location like '%" + Location + "%'", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from tblStaffMember", sqlConn);
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
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserAccess " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            DS = new dsUserAccess();
            sqlDA.Fill(DS.tblUserAccess);
            return DS;
        }

    }
}


