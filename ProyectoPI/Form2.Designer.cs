namespace ProyectoPI
{
    partial class Form2
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.saveImg = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.filtroTransaparencia = new System.Windows.Forms.Button();
            this.filtroSepia = new System.Windows.Forms.Button();
            this.filtroNegativo = new System.Windows.Forms.Button();
            this.filtroBinario = new System.Windows.Forms.Button();
            this.filtroGris = new System.Windows.Forms.Button();
            this.menuFiltros = new System.Windows.Forms.Button();
            this.cargaImg = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.imgOrigen = new System.Windows.Forms.PictureBox();
            this.imgResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramRed = new AForge.Controls.Histogram();
            this.histogramGreen = new AForge.Controls.Histogram();
            this.histogramBlue = new AForge.Controls.Histogram();
            this.panelSideMenu.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.saveImg);
            this.panelSideMenu.Controls.Add(this.panelFiltros);
            this.panelSideMenu.Controls.Add(this.menuFiltros);
            this.panelSideMenu.Controls.Add(this.cargaImg);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 554);
            this.panelSideMenu.TabIndex = 1;
            // 
            // saveImg
            // 
            this.saveImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveImg.FlatAppearance.BorderSize = 0;
            this.saveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImg.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveImg.Location = new System.Drawing.Point(0, 299);
            this.saveImg.Name = "saveImg";
            this.saveImg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.saveImg.Size = new System.Drawing.Size(150, 45);
            this.saveImg.TabIndex = 4;
            this.saveImg.Text = "Guardar Imagen";
            this.saveImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveImg.UseVisualStyleBackColor = true;
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFiltros.Controls.Add(this.filtroTransaparencia);
            this.panelFiltros.Controls.Add(this.filtroSepia);
            this.panelFiltros.Controls.Add(this.filtroNegativo);
            this.panelFiltros.Controls.Add(this.filtroBinario);
            this.panelFiltros.Controls.Add(this.filtroGris);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 90);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(150, 209);
            this.panelFiltros.TabIndex = 3;
            // 
            // filtroTransaparencia
            // 
            this.filtroTransaparencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtroTransaparencia.FlatAppearance.BorderSize = 0;
            this.filtroTransaparencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtroTransaparencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.filtroTransaparencia.Location = new System.Drawing.Point(0, 160);
            this.filtroTransaparencia.Name = "filtroTransaparencia";
            this.filtroTransaparencia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filtroTransaparencia.Size = new System.Drawing.Size(150, 40);
            this.filtroTransaparencia.TabIndex = 7;
            this.filtroTransaparencia.Text = "Transaprencia";
            this.filtroTransaparencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtroTransaparencia.UseVisualStyleBackColor = true;
            this.filtroTransaparencia.Click += new System.EventHandler(this.filtroTransaparencia_Click);
            // 
            // filtroSepia
            // 
            this.filtroSepia.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtroSepia.FlatAppearance.BorderSize = 0;
            this.filtroSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtroSepia.ForeColor = System.Drawing.Color.Gainsboro;
            this.filtroSepia.Location = new System.Drawing.Point(0, 120);
            this.filtroSepia.Name = "filtroSepia";
            this.filtroSepia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filtroSepia.Size = new System.Drawing.Size(150, 40);
            this.filtroSepia.TabIndex = 6;
            this.filtroSepia.Text = "Sepia";
            this.filtroSepia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtroSepia.UseVisualStyleBackColor = true;
            this.filtroSepia.Click += new System.EventHandler(this.filtroSepia_Click);
            // 
            // filtroNegativo
            // 
            this.filtroNegativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtroNegativo.FlatAppearance.BorderSize = 0;
            this.filtroNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtroNegativo.ForeColor = System.Drawing.Color.Gainsboro;
            this.filtroNegativo.Location = new System.Drawing.Point(0, 80);
            this.filtroNegativo.Name = "filtroNegativo";
            this.filtroNegativo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filtroNegativo.Size = new System.Drawing.Size(150, 40);
            this.filtroNegativo.TabIndex = 5;
            this.filtroNegativo.Text = "Negativo";
            this.filtroNegativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtroNegativo.UseVisualStyleBackColor = true;
            this.filtroNegativo.Click += new System.EventHandler(this.filtroNegativo_Click);
            // 
            // filtroBinario
            // 
            this.filtroBinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtroBinario.FlatAppearance.BorderSize = 0;
            this.filtroBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtroBinario.ForeColor = System.Drawing.Color.Gainsboro;
            this.filtroBinario.Location = new System.Drawing.Point(0, 40);
            this.filtroBinario.Name = "filtroBinario";
            this.filtroBinario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filtroBinario.Size = new System.Drawing.Size(150, 40);
            this.filtroBinario.TabIndex = 4;
            this.filtroBinario.Text = "Binario";
            this.filtroBinario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtroBinario.UseVisualStyleBackColor = true;
            this.filtroBinario.Click += new System.EventHandler(this.filtroBinario_Click);
            // 
            // filtroGris
            // 
            this.filtroGris.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtroGris.FlatAppearance.BorderSize = 0;
            this.filtroGris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtroGris.ForeColor = System.Drawing.Color.Gainsboro;
            this.filtroGris.Location = new System.Drawing.Point(0, 0);
            this.filtroGris.Name = "filtroGris";
            this.filtroGris.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filtroGris.Size = new System.Drawing.Size(150, 40);
            this.filtroGris.TabIndex = 3;
            this.filtroGris.Text = "Grises";
            this.filtroGris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtroGris.UseVisualStyleBackColor = true;
            this.filtroGris.Click += new System.EventHandler(this.filtroGris_Click);
            // 
            // menuFiltros
            // 
            this.menuFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuFiltros.FlatAppearance.BorderSize = 0;
            this.menuFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuFiltros.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuFiltros.Location = new System.Drawing.Point(0, 45);
            this.menuFiltros.Name = "menuFiltros";
            this.menuFiltros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuFiltros.Size = new System.Drawing.Size(150, 45);
            this.menuFiltros.TabIndex = 2;
            this.menuFiltros.Text = "Filtros";
            this.menuFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuFiltros.UseVisualStyleBackColor = true;
            this.menuFiltros.Click += new System.EventHandler(this.menuFiltros_Click);
            // 
            // cargaImg
            // 
            this.cargaImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.cargaImg.FlatAppearance.BorderSize = 0;
            this.cargaImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargaImg.ForeColor = System.Drawing.Color.Gainsboro;
            this.cargaImg.Location = new System.Drawing.Point(0, 0);
            this.cargaImg.Name = "cargaImg";
            this.cargaImg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cargaImg.Size = new System.Drawing.Size(150, 45);
            this.cargaImg.TabIndex = 1;
            this.cargaImg.Text = "Cargar Imagen";
            this.cargaImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargaImg.UseVisualStyleBackColor = true;
            this.cargaImg.Click += new System.EventHandler(this.cargaImg_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeBtn.Location = new System.Drawing.Point(156, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.closeBtn.Size = new System.Drawing.Size(44, 45);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imgOrigen
            // 
            this.imgOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.imgOrigen.Location = new System.Drawing.Point(222, 27);
            this.imgOrigen.Name = "imgOrigen";
            this.imgOrigen.Size = new System.Drawing.Size(320, 240);
            this.imgOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOrigen.TabIndex = 6;
            this.imgOrigen.TabStop = false;
            // 
            // imgResult
            // 
            this.imgResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.imgResult.Location = new System.Drawing.Point(222, 302);
            this.imgResult.Name = "imgResult";
            this.imgResult.Size = new System.Drawing.Size(320, 240);
            this.imgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResult.TabIndex = 7;
            this.imgResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(354, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(346, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado";
            // 
            // histogramRed
            // 
            this.histogramRed.Location = new System.Drawing.Point(589, 56);
            this.histogramRed.Name = "histogramRed";
            this.histogramRed.Size = new System.Drawing.Size(298, 139);
            this.histogramRed.TabIndex = 10;
            this.histogramRed.Text = "histogramRed";
            this.histogramRed.Values = null;
            // 
            // histogramGreen
            // 
            this.histogramGreen.Location = new System.Drawing.Point(589, 216);
            this.histogramGreen.Name = "histogramGreen";
            this.histogramGreen.Size = new System.Drawing.Size(298, 139);
            this.histogramGreen.TabIndex = 11;
            this.histogramGreen.Text = "histogramRed";
            this.histogramGreen.Values = null;
            // 
            // histogramBlue
            // 
            this.histogramBlue.Location = new System.Drawing.Point(589, 381);
            this.histogramBlue.Name = "histogramBlue";
            this.histogramBlue.Size = new System.Drawing.Size(298, 139);
            this.histogramBlue.TabIndex = 12;
            this.histogramBlue.Text = "histogramRed";
            this.histogramBlue.Values = null;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.histogramBlue);
            this.Controls.Add(this.histogramGreen);
            this.Controls.Add(this.histogramRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgResult);
            this.Controls.Add(this.imgOrigen);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelSideMenu.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button saveImg;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button filtroBinario;
        private System.Windows.Forms.Button filtroGris;
        private System.Windows.Forms.Button menuFiltros;
        private System.Windows.Forms.Button cargaImg;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox imgOrigen;
        private System.Windows.Forms.PictureBox imgResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filtroTransaparencia;
        private System.Windows.Forms.Button filtroSepia;
        private System.Windows.Forms.Button filtroNegativo;
        private AForge.Controls.Histogram histogramRed;
        private AForge.Controls.Histogram histogramGreen;
        private AForge.Controls.Histogram histogramBlue;
    }
}