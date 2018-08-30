using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace lenna
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _InputImage;
        Image<Gray, byte> _GrayImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            string Filename = "c:\\lennas.jpg";
            _InputImage = new Image<Bgr, byte>(Filename);

            if (_InputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }

            imageBox1.Image = _InputImage;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;

        }

        private void btngtis_Click(object sender, EventArgs e)
        { 
            _GrayImage = _InputImage.Convert<Gray, byte>();


            if (_InputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }

            imageBox2.Image = _GrayImage;
            imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _InputImage[0] }, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            histogramBox1.AddHistogram("Histograma de color azul", Color.Blue, m, 256, new float[] { 0, 255});
            histogramBox1.Refresh();
        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
