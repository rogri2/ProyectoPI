namespace ProyectoPI
{
    partial class ShotoPhop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShotoPhop));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.editVideo = new System.Windows.Forms.Button();
            this.editImg = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.editVideo);
            this.panelSideMenu.Controls.Add(this.editImg);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 554);
            this.panelSideMenu.TabIndex = 0;
            // 
            // editVideo
            // 
            this.editVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.editVideo.FlatAppearance.BorderSize = 0;
            this.editVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editVideo.ForeColor = System.Drawing.Color.Gainsboro;
            this.editVideo.Location = new System.Drawing.Point(0, 145);
            this.editVideo.Name = "editVideo";
            this.editVideo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.editVideo.Size = new System.Drawing.Size(150, 45);
            this.editVideo.TabIndex = 2;
            this.editVideo.Text = "Editar Video";
            this.editVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editVideo.UseVisualStyleBackColor = true;
            this.editVideo.Click += new System.EventHandler(this.editVideo_Click);
            // 
            // editImg
            // 
            this.editImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.editImg.FlatAppearance.BorderSize = 0;
            this.editImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editImg.ForeColor = System.Drawing.Color.Gainsboro;
            this.editImg.Location = new System.Drawing.Point(0, 100);
            this.editImg.Name = "editImg";
            this.editImg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.editImg.Size = new System.Drawing.Size(150, 45);
            this.editImg.TabIndex = 1;
            this.editImg.Text = "Editar Imagen";
            this.editImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editImg.UseVisualStyleBackColor = true;
            this.editImg.Click += new System.EventHandler(this.editImg_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPI.Properties.Resources.Shotophop;
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(150, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(917, 554);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ProyectoPI.Properties.Resources.Shotophop;
            this.pictureBox2.Location = new System.Drawing.Point(320, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ShotoPhop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1083, 593);
            this.Name = "ShotoPhop";
            this.Text = "ShotoPhop";
            this.Load += new System.EventHandler(this.ShotoPhop_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button editVideo;
        private System.Windows.Forms.Button editImg;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

