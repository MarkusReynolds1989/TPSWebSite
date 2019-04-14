//Staff Portal Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
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
        string savePath = @"C:\Users\Reynolds\source\repos\MarkusReynolds1989\TPSWebSite\Pictures\";
        if (fileupPicture.HasFile)
        {
            string FileName = fileupPicture.FileName;
            string picture = fileupPicture.FileName;
            savePath += FileName;
            fileupPicture.SaveAs(savePath);
            error.Text = "Your file was uploaded as" + FileName;

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