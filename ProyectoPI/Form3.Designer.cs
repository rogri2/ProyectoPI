namespace ProyectoPI
{
    partial class Form3
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
            this.playVid = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.filtroTransaparencia = new System.Windows.Forms.Button();
            this.filtroSepia = new System.Windows.Forms.Button();
            this.filtroNegativo = new System.Windows.Forms.Button();
            this.filtroBinario = new System.Windows.Forms.Button();
            this.filtroGris = new System.Windows.Forms.Button();
            this.menuFiltros = new System.Windows.Forms.Button();
            this.cargaVid = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vidOrigen = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.playVid);
            this.panelSideMenu.Controls.Add(this.panelFiltros);
            this.panelSideMenu.Controls.Add(this.menuFiltros);
            this.panelSideMenu.Controls.Add(this.cargaVid);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 554);
            this.panelSideMenu.TabIndex = 2;
            // 
            // playVid
            // 
            this.playVid.Dock = System.Windows.Forms.DockStyle.Top;
            this.playVid.FlatAppearance.BorderSize = 0;
            this.playVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playVid.ForeColor = System.Drawing.Color.Gainsboro;
            this.playVid.Location = new System.Drawing.Point(0, 297);
            this.playVid.Name = "playVid";
            this.playVid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.playVid.Size = new System.Drawing.Size(150, 45);
            this.playVid.TabIndex = 4;
            this.playVid.Text = "Play Video";
            this.playVid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playVid.UseVisualStyleBackColor = true;
            this.playVid.Click += new System.EventHandler(this.playVid_Click);
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
            this.panelFiltros.Size = new System.Drawing.Size(150, 207);
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
            this.filtroTransaparencia.TabIndex = 8;
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
            this.filtroSepia.TabIndex = 7;
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
            this.filtroNegativo.TabIndex = 6;
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
            // cargaVid
            // 
            this.cargaVid.Dock = System.Windows.Forms.DockStyle.Top;
            this.cargaVid.FlatAppearance.BorderSize = 0;
            this.cargaVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargaVid.ForeColor = System.Drawing.Color.Gainsboro;
            this.cargaVid.Location = new System.Drawing.Point(0, 0);
            this.cargaVid.Name = "cargaVid";
            this.cargaVid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cargaVid.Size = new System.Drawing.Size(150, 45);
            this.cargaVid.TabIndex = 1;
            this.cargaVid.Text = "Cargar Video";
            this.cargaVid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargaVid.UseVisualStyleBackColor = true;
            this.cargaVid.Click += new System.EventHandler(this.cargaVid_Click);
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
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // vidOrigen
            // 
            this.vidOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vidOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.vidOrigen.Location = new System.Drawing.Point(173, 72);
            this.vidOrigen.Name = "vidOrigen";
            this.vidOrigen.Size = new System.Drawing.Size(720, 405);
            this.vidOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vidOrigen.TabIndex = 7;
            this.vidOrigen.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.vidOrigen);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panelSideMenu.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vidOrigen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button filtroBinario;
        private System.Windows.Forms.Button filtroGris;
        private System.Windows.Forms.Button menuFiltros;
        private System.Windows.Forms.Button cargaVid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox vidOrigen;
        private System.Windows.Forms.Button filtroNegativo;
        private System.Windows.Forms.Button filtroSepia;
        private System.Windows.Forms.Button filtroTransaparencia;
        private System.Windows.Forms.Button playVid;
    }
}