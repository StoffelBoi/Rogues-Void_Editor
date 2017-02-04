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
        string path = @"E:\Diplomarbeit\Rogues-Void\Content\RoguesVoid\Textures";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImagesFromPath();
        }

        public void CreateCanvas()
        {
           //Canvas DrawLevel = new Canvas();
        }

        public void LoadImagesFromPath()
        {
            DirectoryInfo folder;
            FileInfo[] Images;

            folder = new DirectoryInfo(path);
            try
            {
               Images = folder.GetFiles("*.png", SearchOption.AllDirectories);

                foreach (FileInfo image in Images)
                {
                    imageList1.Images.Add(Image.FromFile(image.FullName));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Filesearch unsuccesful", e);
            }

            lvImages.View = View.LargeIcon;
            imageList1.ImageSize = new Size(64, 64);
            lvImages.LargeImageList = imageList1;

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                lvImages.Items.Add(item);
            }
        }

        private void lvImages_ItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem item in lvImages.SelectedItems)
            {
                int imageIndex = item.ImageIndex;
                if (imageIndex >= 0 && imageIndex < imageList1.Images.Count)
                    TileView.Image = imageList1.Images[imageIndex];
            }
        }
    }
}
