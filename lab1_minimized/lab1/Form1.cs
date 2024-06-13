using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;


namespace lab1
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private VideoCapture capture;
        private int cannyThreshold;
        private int cannyThresholdLinking;
        private Image<Bgr, byte> image;
        private Image<Gray, byte> cannyEdges;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);
                Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();
                imageBox3.Image = grayImage;
                var tempImage = grayImage.PyrDown();
                var destImage = tempImage.PyrUp();
                Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);
                imageBox3.SizeMode = PictureBoxSizeMode.Zoom;
                //imageBox3.Image = cannyEdges;

                var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
                var resultImage = sourceImage.Sub(cannyEdgesBgr); // попиксельное вычитание
                                                                  //обход по каналам
                for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
                    for (int x = 0; x < resultImage.Width; x++)
                        for (int y = 0; y < resultImage.Height; y++) // обход по пискелям
                        {
                            // получение цвета пикселя
                            byte color = resultImage.Data[y, x, channel];
                            if (color <= 50)
                                color = 0;
                            else if (color <= 100)
                                color = 25;
                            else if (color <= 150)
                                color = 180;
                            else if (color <= 200)
                                color = 210;
                            else
                                color = 255;
                            resultImage.Data[y, x, channel] = color; // изменение цвета пикселя
                        }
                imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
                imageBox1.Image = resultImage.Resize(640, 480, Inter.Linear);
            }

        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_open_video_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            capture.Retrieve(frame); // получение текущего кадра
            if (frame.IsEmpty)
            {
                capture.Stop();
                capture.Dispose();
                imageBox1.Image?.Dispose(); // Освобождаем изображение, если оно существует
                imageBox3.Image?.Dispose();
                imageBox1.Image = null;
                imageBox3.Image = null;
                return; // выходим из метода после очистки
            }
            image = frame.ToImage<Bgr, byte>();
            cannyEdges = image.Canny(cannyThreshold, cannyThresholdLinking);
            imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox3.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox1.Image = frame;
            imageBox3.Image = cannyEdges;

        }

        private void button_stop_video_Click(object sender, EventArgs e)
        {
            capture.Stop();
            capture.Dispose();
            imageBox1.Image.Dispose();
            imageBox1.Image = null;
            imageBox3.Image.Dispose();
            imageBox3.Image = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            cannyThreshold = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();
            cannyThresholdLinking = trackBar2.Value;
        }

        private void button_open_video_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                capture = new VideoCapture(fileName);
                capture.ImageGrabbed += ProcessFrame;
                capture.Start();
            }
        }

 
    }
}