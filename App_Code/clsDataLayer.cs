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

/// this is code from my other class I'm using as a guide
/// we will be basically using this as it's perfectly good for getting items from a database

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
        public static bool ApproveContract(string Database, string ContractID, string RequestID)
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
                strSQL = "Insert into tblContracts (ContractID, RequestID)" + "values ('" + ContractID + "','"
                    + RequestID + "')";
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
                strSQL = "Insert into tblUserAccess (Username, Password, AccessLevel)" + "values ('" + UserName + "','"
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
        public static bool SaveStaff(string Database, string FirstName, string LastName, string EduLevel, string Experience, string Salary)
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

        /* Deny Contract Manager Only
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

        public static bool DenyRequest(string Database, string RequestID)
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
            sqlDA = new OleDbDataAdapter("select * from tblContracts", sqlConn); //How can we display salary as $
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
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0" + "Data Source =" + Database);
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
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0" + "Data Source =" + Database);
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
        public static dsUserAccess AcessUsers(string Database)
        {
            dsUserAccess DS;
            //Call Objects
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Methods for connection, query
            sqlConn = new OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0" + "Data Source =" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblUserAccess", sqlConn);
            //datastream class
            DS = new dsUserAccess();
            //fill table
            sqlDA.Fill(DS.tblUserAccess);
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
            if (Experience != null || Experience.Trim() != "")
            {
                //need to figure this out better, I don't want to have to write code for every combination
                sqlDA = new OleDbDataAdapter("select * from tblStaffMember where Experience like '%" + 
                    Experience + "%'" ,sqlConn);
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
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            DS = new dsUserAccess();
            sqlDA.Fill(DS.tblUserAccess);
            return DS;
        }

        /*IP4 For Security/
        ///////////////////
        //////////////////*/
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;
            foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                }
                break;
            }
            return IP4Address;
        }

    }
}
    

