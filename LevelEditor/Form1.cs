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

        public List<String> GetImagesFromPath()
        {
            DirectoryInfo folder;
            FileInfo[] Images;

            folder = new DirectoryInfo(path);
            Images = folder.GetFiles("*.png", SearchOption.AllDirectories);
            List<String> imagesList = new List<String>();



            return imagesList;
        }
    }
}
