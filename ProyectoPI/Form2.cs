using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesign();
        }

        #region Buttons
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuFiltros_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelFiltros);
        }

        private void cargaImg_Click(object sender, EventArgs e)
        {
            loadImg(imgOrigen);
        }

        private void filtroGris_Click(object sender, EventArgs e)
        {
            useFilter(imgOrigen, imgResult, gray);
            toggleSubmenu(panelFiltros);
        }

        private void filtroBinario_Click(object sender, EventArgs e)
        {
            useFilter(imgOrigen, imgResult, binario);
            toggleSubmenu(panelFiltros);
        }

        private void filtroNegativo_Click(object sender, EventArgs e)
        {
            //useFilter(imgOrigen, imgResult, negativo);
            toggleSubmenu(panelFiltros);
        }

        private void filtroSepia_Click(object sender, EventArgs e)
        {
            //useFilter(imgOrigen, imgResult, sepia);
            toggleSubmenu(panelFiltros);
        }

        private void filtroTransaparencia_Click(object sender, EventArgs e)
        {
            //useFilter(imgOrigen, imgResult, transparencia);
            toggleSubmenu(panelFiltros);
        }

        #endregion

        #region usarFiltros
        private void useFilter(PictureBox org, PictureBox res, Func<Bitmap, int> filtro)
        {
            if (org.Image != null)
            {
                applyFilter(org, res, filtro);
            }
            else
            {
                DialogResult result = MessageBox.Show("Carga una imagen primero. ¿Deseas cargar una imagen ahora?", "Error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (loadImg(imgOrigen))
                        applyFilter(org, res, filtro);
                }
            }
        }

        private void applyFilter(PictureBox org, PictureBox res, Func<Bitmap, int> filtro)
        {
            Bitmap img = new Bitmap(org.Image);
            filtro(img);
            res.Image = img;
        }

        #endregion

        #region Filtros
        private int gray(Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelRGB = img.GetPixel(i, j);

                    int rojo = pixelRGB.R;
                    int verde = pixelRGB.G;
                    int azul = pixelRGB.B;

                    int pixelGray = (rojo + verde + azul) / 3;

                    img.SetPixel(i, j, Color.FromArgb(pixelGray, pixelGray, pixelGray));

                }
            }
            return 0;
        }

        private int binario(Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelRGB = img.GetPixel(i, j);

                    int rojo = pixelRGB.R;
                    int verde = pixelRGB.G;
                    int azul = pixelRGB.B;

                    int pixelGray = (rojo + verde + azul) / 3;

                    if (pixelGray > 127)
                        pixelGray = 255;
                    else
                        pixelGray = 0;
                    
                    img.SetPixel(i, j, Color.FromArgb(pixelGray, pixelGray, pixelGray));
                }
            }

            return 0;
        }

        private int negativo(Bitmap img)
        {
            // Code
            return 0;
        }

        private int sepia(Bitmap img)
        {
            // Code
            return 0;
        }

        private int transparencia(Bitmap img)
        {
            // Code
            return 0;
        }

        #endregion

        #region extraFunctions
        private void customizeDesign()
        {
            panelFiltros.Visible = false;
        }

        private void toggleSubmenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        private bool loadImg(PictureBox org)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                org.Image = new Bitmap(ofd.FileName);
                return true;
            }
            else
                return false;
                
        }

        #endregion

    }
}
