namespace LevelEditor
{
    partial class Form1
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TileView = new System.Windows.Forms.PictureBox();
            this.lboimages = new System.Windows.Forms.ListBox();
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
            this.TileView.Location = new System.Drawing.Point(524, 266);
            this.TileView.Name = "TileView";
            this.TileView.Size = new System.Drawing.Size(153, 86);
            this.TileView.TabIndex = 0;
            this.TileView.TabStop = false;
            // 
            // lboimages
            // 
            this.lboimages.FormattingEnabled = true;
            this.lboimages.Location = new System.Drawing.Point(524, 9);
            this.lboimages.Name = "lboimages";
            this.lboimages.Size = new System.Drawing.Size(153, 251);
            this.lboimages.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 364);
            this.Controls.Add(this.lboimages);
            this.Controls.Add(this.TileView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TileView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox TileView;
        private System.Windows.Forms.ListBox lboimages;
    }
}

