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
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuFiltros = new System.Windows.Forms.Button();
            this.cargaVid = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vidOrigen = new System.Windows.Forms.PictureBox();
            this.filtroNegativo = new System.Windows.Forms.Button();
            this.filtroSepia = new System.Windows.Forms.Button();
            this.filtroTransaparencia = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelFiltros);
            this.panelSideMenu.Controls.Add(this.menuFiltros);
            this.panelSideMenu.Controls.Add(this.cargaVid);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 554);
            this.panelSideMenu.TabIndex = 2;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFiltros.Controls.Add(this.filtroTransaparencia);
            this.panelFiltros.Controls.Add(this.filtroSepia);
            this.panelFiltros.Controls.Add(this.filtroNegativo);
            this.panelFiltros.Controls.Add(this.button2);
            this.panelFiltros.Controls.Add(this.button1);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 90);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(150, 207);
            this.panelFiltros.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Binario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Grises";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
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
            this.vidOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.vidOrigen.Location = new System.Drawing.Point(217, 45);
            this.vidOrigen.Name = "vidOrigen";
            this.vidOrigen.Size = new System.Drawing.Size(640, 480);
            this.vidOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vidOrigen.TabIndex = 7;
            this.vidOrigen.TabStop = false;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button menuFiltros;
        private System.Windows.Forms.Button cargaVid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox vidOrigen;
        private System.Windows.Forms.Button filtroNegativo;
        private System.Windows.Forms.Button filtroSepia;
        private System.Windows.Forms.Button filtroTransaparencia;
    }
}