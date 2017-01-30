using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class Form1 : Form
    {
        string path = "C:'\'Diplomarbeit'\'Rogues-Void'\'Content'\'RoguesVoid'\'Textures";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadImagesFromPath()
        {
            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(16, 16);


            DirectoryInfo folder;
            FileInfo[] Images;

            folder = new DirectoryInfo(path);
            try
            {
               Images = folder.GetFiles("*.png", SearchOption.AllDirectories);

                foreach (FileInfo image in Images)
                {
                    imageList1.Images.Add(Image.FromFile("E:\Diplomarbeit\Rogues-Void\Content\RoguesVoid\Textures\Items\Battery.png");
                }
            }
            catch (Exception e)
            {
                //ToDo exception handeling
            }

            Graphics graphic = Graphics.FromHwnd(this.Handle);

            for(int count = 0; count < imageList1.Images.Count; count++)
            {
                imageList1.Draw(graphic, new Point(16, 16), count);

                Application.DoEvents();

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
