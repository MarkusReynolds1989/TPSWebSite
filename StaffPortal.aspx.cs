using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffPortal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpdate_OnButtonClick(object sender, EventArgs e)
    {
        //Eddie, you can just copy this upload method for the resume, save it to the resume folder,
        //the other two things you can just take from the text boxes
        //string savePath = @"\Pictures" this is what we will use when we publish it
        string savePath = @"C:\Users\Reynolds\source\repos\TPSWebSite\Pictures\";
        if (fileupPicture.HasFile)
        {
            string FileName = fileupPicture.FileName;
            string picture = fileupPicture.FileName;
            savePath += FileName;
            fileupPicture.SaveAs(savePath);
            error.Text = "Your file was uploaded as" + FileName;

            //This will not work
            if (TPS.App_Code.clsDataLayer.UpdateStaffPortal(Server.MapPath("TPS.accdb"), null, null, null, picture))
            {
                error.Text = "Successfully updated profile";
            }
            else
            {
                error.Text = "Failed to update profile";
            }
        }
        else
        {
            error.Text = "Please specify file to upload";
        }
    }
}