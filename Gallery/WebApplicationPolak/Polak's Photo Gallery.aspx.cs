using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPolak
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string photoFolder = Path.Combine(Server.MapPath("~/Photos/"), User.Identity.Name);
            DisplayUploadedPhotos(photoFolder);
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string photoFolder = Path.Combine(Server.MapPath("~/Photos/"), User.Identity.Name);
            if (Directory.Exists(photoFolder) == false)
            {
                Directory.CreateDirectory(photoFolder);
            }
            
            if (FileUpload1.HasFile == false)
            {
                LabelStatus.Text = "Choose a file!";
            }
            if (Convert.ToInt64(FileUpload1.PostedFile.ContentLength) > 10000000)
            {
                LabelStatus.Text = "File should be less than 10MB";
            }
            if ((FileUpload1.PostedFile.ContentType == "image/jpeg") 
                || (FileUpload1.PostedFile.ContentType == "image/png")
                || (FileUpload1.PostedFile.ContentType == "image/gif")
                || (FileUpload1.PostedFile.ContentType == "image/bmp"))
            {
                string name = Path.GetFileNameWithoutExtension(FileUpload1.FileName);
                string time = DateTime.Now.Ticks.ToString();
                string extension = Path.GetExtension(FileUpload1.FileName);
                string full_file_path = Path.Combine(photoFolder, name + time + extension);
                FileUpload1.SaveAs(full_file_path);
                LabelStatus.Text = "<font color='green'> Successfully uploaded file " + FileUpload1.FileName + "</font>";
                DisplayUploadedPhotos(photoFolder);


            }
            else
            {
                LabelStatus.Text = "File should be jpg / gif / png / bmp ";

            }
        }
        public void DisplayUploadedPhotos(string folder)
        {
            string[] allPhotoFiles = Directory.GetFiles(folder);            List<String> pathList = new List<String>();
            foreach (String file in allPhotoFiles)
            {
                pathList.Add("~/Photos/" + User.Identity.Name + "/" + Path.GetFileName(file));
            }
            RepeaterUserPhoto.DataSource = pathList;
            RepeaterUserPhoto.DataBind();
        }
    }
}