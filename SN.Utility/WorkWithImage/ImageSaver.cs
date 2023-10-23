using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN.Utility.WorkWithImage
{
    public static class ImageSaver
    {
        public static string ImageCreator(this PictureBox pb)
        {
            string UImage = "";
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = openFile.FileName;
                string imageName = Guid.NewGuid() + Path.GetExtension(pb.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                MessageBox.Show("path : " + path + " image name :" + imageName);
                UImage = path + imageName;
                pb.Image.Save(UImage);
            }
            return UImage;

        }
    }
}
