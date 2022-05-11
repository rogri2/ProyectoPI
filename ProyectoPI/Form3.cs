using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace ProyectoPI
{
    public partial class Form3 : Form
    {
        VideoCapture video;
        Image<Bgr, Byte> currentFrame;
        double duracion;
        double cantFrames;
        bool isVideoLoaded = false;
        string filtro = "";

        public Form3()
        {
            InitializeComponent();
            customizeDesign();
        }

        #region Botones
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuFiltros_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelFiltros);
        }

        private void cargaVid_Click(object sender, EventArgs e)
        {
            loadVideo(vidOrigen);

        }

        private void playVid_Click(object sender, EventArgs e)
        {
            playVideoMain();
        }

        private void filtroGris_Click(object sender, EventArgs e)
        {
            filtro = "gris";
            playVideoMain();
            toggleSubmenu(panelFiltros);
        }

        private void filtroBinario_Click(object sender, EventArgs e)
        {
            filtro = "binario";
            playVideoMain();
            toggleSubmenu(panelFiltros);
        }

        private void filtroNegativo_Click(object sender, EventArgs e)
        {
            filtro = "negativo";
            playVideoMain();
            toggleSubmenu(panelFiltros);
        }

        private void filtroSepia_Click(object sender, EventArgs e)
        {
            filtro = "sepia";
            playVideoMain();
            toggleSubmenu(panelFiltros);
        }

        private void filtroTransaparencia_Click(object sender, EventArgs e)
        {
            filtro = "transparencia";
            playVideoMain();
            toggleSubmenu(panelFiltros);
        }

        #endregion

        #region Videos

        private void playVideoMain()
        {
            if (isVideoLoaded)
            {
                /*DialogResult result = MessageBox.Show("El video se reproducirá indefinidamente.");
                if (result == DialogResult.OK)
                {
                    Application.Idle += new EventHandler(playVideo);
                }*/
                Application.Idle += new EventHandler(playVideo);
            }
            else
            {
                DialogResult result = MessageBox.Show("Carga un video primero. ¿Deseas cargar un video ahora?", "Error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    loadVideo(vidOrigen);
                    Application.Idle += new EventHandler(playVideo);
                }
            }
        }

        private void playVideo(object sender, EventArgs e)
        {
            if (cantFrames < duracion - 2)
            {
                Mat m = new Mat();
                video.Read(m);

                currentFrame = new Image<Bgr, Byte>(m.Bitmap);
                currentFrame.Resize(vidOrigen.Width, vidOrigen.Height, Inter.Cubic);
                cantFrames = video.GetCaptureProperty(CapProp.PosFrames);

                vidOrigen.Image = currentFrame.Bitmap;
            }
            else
            {
                cantFrames = 0;
                video.SetCaptureProperty(CapProp.PosFrames, 0);
            }

            switch (filtro)
            {
                case "gris":
                    {
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{0.3f, 0.3f, 0.3f, 0, 0},
                            new float[]{0.59f, 0.59f, 0.59f, 0, 0},
                            new float[]{ 0.11f, 0.11f, 0.11f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                        applyFilter(cmPicture);
                        break;
                    }
                case "binario":
                    {
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{0, 0, 0, 0, 0},
                            new float[]{0, 1, 0, 0, 0},
                            new float[]{ 0, 0, 0, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                        applyFilter(cmPicture);
                        break;
                    }
                case "negativo":
                    {
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                        });
                        applyFilter(cmPicture);
                        break;
                    }
                case "sepia":
                    {
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{.393f, .349f, .272f, 0, 0},
                            new float[]{.769f, .686f, .534f, 0, 0},
                            new float[]{.189f, .168f, .131f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                        applyFilter(cmPicture);
                        break;
                    }
                case "transparencia":
                    {
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{1, 0, 0, 0, 0},
                            new float[]{0, 1, 0, 0, 0},
                            new float[]{0, 0, 1, 0, 0},
                            new float[]{0, 0, 0, 0.3f, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                        applyFilter(cmPicture);
                        break;
                    }
                default:
                    {
                        vidOrigen.Image = currentFrame.Bitmap;
                        break;
                    }
            }

        }

        private bool loadVideo(PictureBox img)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de video (*.mp4)|*.mp4";

            if (file.ShowDialog() == DialogResult.OK)
            {
                video = new VideoCapture(file.FileName);
                video.QueryFrame();

                Mat m = new Mat();
                video.Read(m);

                currentFrame = new Image<Bgr, Byte>(m.Bitmap);
                currentFrame.Resize(img.Width, img.Height, Inter.Cubic);

                img.Image = currentFrame.Bitmap;

                duracion = video.GetCaptureProperty(CapProp.FrameCount);
                cantFrames = video.GetCaptureProperty(CapProp.PosFrames);

                isVideoLoaded = true;

                img.BackgroundImage = null;

                return true;
            }
            else
                return false;
        }

        private void applyFilter(ColorMatrix CM_Picture)
        {
            Image img = currentFrame.Bitmap;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(CM_Picture);
            Graphics gr = Graphics.FromImage(bmpInverted);

            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imageAttributes);
            gr.Dispose();
            vidOrigen.Image = bmpInverted;
        }

        #endregion

        #region Extras

        private void customizeDesign()
        {
            panelFiltros.Visible = false;
        }

        private void toggleSubmenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        #endregion

    }
}
