//UserManagement Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserManagement : System.Web.UI.Page
{
    //consider making this static
    private string UserId { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        dsUserAccess myDataSet = TPS.App_Code.clsDataLayer.AccessUsers(Server.MapPath("TPSWebsite.mdf"));
        //set the datagrid to datasource based on table
        grdViewUsers.DataSource = myDataSet.Tables["tblUserAccess"];
        //the datagrid
        grdViewUsers.DataBind();
    }

    protected void OnButtonClick_AddUser(object sender, EventArgs e)
    {
        try
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            int SecurityLevel = Convert.ToInt32(DropDownList1.SelectedValue);
            if (UserName != null || UserName.Trim() != "" && Password != null || Password.Trim() != "")
            {
                if (TPS.App_Code.clsDataLayer.AddUser(Server.MapPath("TPS.accdb"), UserName, Password, SecurityLevel))
                {
                    error.Text = "Successfully added user";
                    BindData();
                }
            }
            else
            {
                error.Text = "Plese fill out all fields";
            }
        }

        catch (NullReferenceException)
        {
            error.Text = "Plese fill out all fields";
        }
    }

    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        UserId = grdViewUsers.SelectedRow.Cells[3].Text;
    }

    protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Add try catch so user can't press this before select button
        //Catch System.NullReferenceException
        try
        {
            UserId = grdViewUsers.SelectedRow.Cells[3].Text;
            if (TPS.App_Code.clsDataLayer.DeleteUser(Server.MapPath("TPS.accdb"), UserId))
            {
                error.Text = "Successfully deleted user";
                BindData();
            }
            else
            {
                error.Text = "Failed to delete user";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Select a row first";
        }
    }

    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        grdViewUsers.EditIndex = e.NewEditIndex;
        BindData();
    }


    protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        BindData();
        grdViewUsers.EditIndex = -1; //swicth back to default mode
        error.Text = "";
    }

    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            TextBox txtUserName = (TextBox)grdViewUsers.SelectedRow.Cells[4].Controls[0];
            string UserName = txtUserName.Text;
            TextBox txtUserPassword = (TextBox)grdViewUsers.SelectedRow.Cells[5].Controls[0];
            string UserPassword = txtUserPassword.Text;
            TextBox txtSecurityLevel = (TextBox)grdViewUsers.SelectedRow.Cells[6].Controls[0];
            string SecurityLevel = txtSecurityLevel.Text;

            if (TPS.App_Code.clsDataLayer.UpdateUser(Server.MapPath("TPSWebsite.mdf"), UserId, UserName, UserPassword, SecurityLevel))
            {
                error.Text = "Successfully Updated";
                BindData();
                grdViewUsers.EditIndex = -1;
            }
            else
            {
                error.Text = "Update failed";
            }
        }

        catch (NullReferenceException)
        {
            error.Text = "Please select a row first";
        }
    }
}
