using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form3()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customizeDesign()
        {
            panelFiltros.Visible = false;
        }

        private void toggleSubmenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        private void menuFiltros_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelFiltros);
        }

        private void cargaVid_Click(object sender, EventArgs e)
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
                currentFrame.Resize(vidOrigen.Width, vidOrigen.Height, Inter.Cubic);

                vidOrigen.Image = currentFrame.Bitmap;

                duracion = video.GetCaptureProperty(CapProp.FrameCount);
                cantFrames = video.GetCaptureProperty(CapProp.PosFrames);

                isVideoLoaded = true;

                vidOrigen.BackgroundImage = null;
            }
        }

        private void playVid_Click(object sender, EventArgs e)
        {
            if (isVideoLoaded)
            {
                DialogResult result = MessageBox.Show("El video se reproducirá indefinidamente.");
                if (result == DialogResult.OK)
                {
                    Application.Idle += new EventHandler(playVideo);
                }
            }
            else
            {
                MessageBox.Show("No hay video cargado.", "Error");
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

        }

    }
}
