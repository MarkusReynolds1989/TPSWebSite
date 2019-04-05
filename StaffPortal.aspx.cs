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
        //Eddie help me out with this one, how can we store an attachment into the database?
        //change the database to hold a huge amount of data, alternatively we might hold a file path
        //let's consider this carefully
        //This doesn't work, probably because the file type, but it tries

        //Check this code out, it might work
        //string savePath = @"\Pictures" this is what we will use when we publish it
        string savePath = @"C:\Users\Reynolds\source\repos\TPSWebSite\Pictures\";
        if (fileupPicture.HasFile)
        {
            Console.Write("Test");
            string FileName = fileupPicture.FileName;
            string picture = fileupPicture.FileName;
            savePath += FileName;
            fileupPicture.SaveAs(savePath);
            error.Text = "Your file was uploaded as" + FileName;
        }
        else
        {
            error.Text = "Please specify file to upload";
        }
    }
}
        /*
        //byte array of the picture
        //new object of fileupload class
        FileUpload file = new FileUpload();
        //we take the content of fileupPicture and hold it in FileUpload
        file = fileupPicture;
        //Convert the file to the byte array assign it to picture
        byte[] picture = File.ReadAllBytes(file.FileName);
        //this doesn't work yet but class the updatestaffportal method
        if (TPS.App_Code.clsDataLayer.UpdateStaffPortal(Server.MapPath("TPS.accdb"), null, null, null, picture))
        {
            error.Text = "Successfully updated profile";
        }
        else
        {
            error.Text = "Failed to update profile";
        }
        //File.ReadAllText(fileupResume); So we will save the file into a path first and then convert it
        //File.ReadAllBytes(fileupPicture); Just need to figure out how
    }
}

/*using (OpenFileDialog fileDialog = new OpenFileDialog){
   if(fileDialog.ShowDialog == DialogResult.OK){
       using (System.IO.FileInfo fileToSave = new System.IO.FileInfo(fileDialog.FilePath)){
          MemoryStream ms = System.IO.FileStream(fileToSave.FullName, IO.FileMode.Open);
*/
//Let's try this next
