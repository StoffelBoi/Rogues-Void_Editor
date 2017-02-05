namespace LevelEditor
{
    partial class LevelEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelEditor));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TileView = new System.Windows.Forms.PictureBox();
            this.lvImages = new System.Windows.Forms.ListView();
            this.lblItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TileView)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TileView
            // 
            this.TileView.Location = new System.Drawing.Point(506, 263);
            this.TileView.Name = "TileView";
            this.TileView.Size = new System.Drawing.Size(171, 89);
            this.TileView.TabIndex = 0;
            this.TileView.TabStop = false;
            // 
            // lvImages
            // 
            this.lvImages.Location = new System.Drawing.Point(506, 12);
            this.lvImages.MultiSelect = false;
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(171, 245);
            this.lvImages.TabIndex = 1;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(51, 55);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(37, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = " . . . . .";
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 364);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.TileView);
            this.Controls.Add(this.lvImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelEditor";
            this.Text = "Level Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TileView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox TileView;
        private System.Windows.Forms.ListView lvImages;
        private System.Windows.Forms.Label lblItem;
    }
}

