using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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

        private void saveImg_Click(object sender, EventArgs e)
        {
            saveImage(imgResult);
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
            useFilter(imgOrigen, imgResult, negativo);
            toggleSubmenu(panelFiltros);
        }

        private void filtroSepia_Click(object sender, EventArgs e)
        {
            useFilter(imgOrigen, imgResult, sepia);
            toggleSubmenu(panelFiltros);
        }

        private void filtroTransaparencia_Click(object sender, EventArgs e)
        {
            useFilter(imgOrigen, imgResult, transparencia);
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
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelRGB = img.GetPixel(i, j);

                    int alfa = pixelRGB.A;
                    int rojo = 255- pixelRGB.R;
                    int verde = 255- pixelRGB.G;
                    int azul = 255- pixelRGB.B;

                    img.SetPixel(i, j, Color.FromArgb(alfa, rojo, verde, azul));

                }
            }
            return 0;
        }

        private int sepia(Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelRGB = img.GetPixel(i, j);

                    int alfa = pixelRGB.A;
                    int rojo = pixelRGB.R;
                    int verde = pixelRGB.G;
                    int azul = pixelRGB.B;

                    int tr = (int)((0.393 * rojo) + (0.769 * verde) + (0.189 * azul));
                    int tg = (int)((0.349 * rojo) + (0.686 * verde) + (0.168 * azul));
                    int tb = (int)((0.272 * rojo) + (0.534 * verde) + (0.131 * azul));

                    rojo = tr > 255 ? 255 : tr;
                    verde = tg > 255 ? 255 : tg;
                    azul = tb > 255 ? 255 : tb;

                    img.SetPixel(i, j, Color.FromArgb(alfa, rojo, verde, azul));

                }
            }
            return 0;
        }

        private int transparencia(Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelRGB = img.GetPixel(i, j);

                    int rojo = pixelRGB.R;
                    int verde = pixelRGB.G;
                    int azul = pixelRGB.B;

                    int pixelAlpha = 100;

                    img.SetPixel(i, j, Color.FromArgb(pixelAlpha, rojo, verde, azul));

                }
            }
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

        private void saveImage(PictureBox img)
        {
            if (img.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG|*.png|JPG|*.jpg";
                ImageFormat format = ImageFormat.Jpeg;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }
                    img.Image.Save(sfd.FileName, format);
                }
            }
            else
                MessageBox.Show("Se debe de aplicar un filtro a una imagen", "Error", MessageBoxButtons.OK);
        }

        #endregion
    }
}
