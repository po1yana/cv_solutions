using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace lab4
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Bgr, byte> processedImage;
        private Image<Bgr, byte> regionsImage;
        private double thresholdValue = 80.0;
        private double minContourArea = 99.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);

                imageBox1.Image = sourceImage;
                imageBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        //1,2
        private void button_remove_noise_Click(object sender, EventArgs e)
        {
            processedImage = sourceImage.Clone(); // Клонируем исходное изображение для обработки
            imageBox2.Image = processedImage;
            if (sourceImage != null)
            {
                var grayImage = sourceImage.Convert<Gray, byte>();
                int kernelSize = 5; // радиус размытия
                var bluredImage = grayImage.SmoothGaussian(kernelSize);

                processedImage = bluredImage.Convert<Bgr, byte>();
                imageBox2.Image = processedImage;
                imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button_detect_regions_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                var grayImage = processedImage.Convert<Gray, byte>();
                var threshold = new Gray(thresholdValue); // пороговое значение
                var color = new Gray(255); // этим цветом будут закрашены пиксели, имеющие значение > threshold
                var binarizedImage = grayImage.ThresholdBinary(threshold, color);

                regionsImage = binarizedImage.Convert<Bgr, byte>();
                imageBox2.Image = regionsImage;
                imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void button_find_contours_Click(object sender, EventArgs e)
        {
            if (regionsImage != null) // Используем сохраненное изображение с обнаруженными областями
            {
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                var contoursImage = sourceImage.CopyBlank(); // Создаем "пустую" копию исходного изображения
                for (int i = 0; i < contours.Size; i++)
                {
                    var points = contours[i].ToArray();
                    contoursImage.Draw(points, new Bgr(Color.GreenYellow), 2); // Отрисовываем контуры
                }

                processedImage = contoursImage;
                imageBox2.Image = processedImage;
                imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        //3
        private void button_find_primitives_Click(object sender, EventArgs e)
        {
            if (regionsImage != null) // Используем сохраненное изображение с обнаруженными областями
            {
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                var primitivesImage = sourceImage.CopyBlank(); // Создаем "пустую" копию исходного изображения

                //double minArea = 256.0; // Минимально допустимая площадь для контуров

                int triangleCount = 0;

                for (int i = 0; i < contours.Size; i++)
                {
                    var approxContour = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approxContour, CvInvoke.ArcLength(contours[i], true) * 0.05, true);

                    if (CvInvoke.ContourArea(approxContour, false) > minContourArea) // Проверка на площадь контура
                    {
                        if (approxContour.Size == 3) // Если контур содержит 3 точки, то это треугольник
                        {
                            var points = approxContour.ToArray();
                            primitivesImage.Draw(new Triangle2DF(points[0], points[1], points[2]), new Bgr(Color.GreenYellow), 2);
                            triangleCount++;
                        }
                        //else // В противном случае просто рисуем аппроксимированный контур
                        //{
                        //    primitivesImage.Draw(approxContour.ToArray(), new Bgr(Color.Red), 2);
                        //}
                    }
                }
                string text = $"Triangles: {triangleCount}";
                Point textLocation = new Point(10, 30); // Позиция текста чуть ниже
                CvInvoke.PutText(primitivesImage, text, textLocation, FontFace.HersheyComplex, 0.7, new MCvScalar(255, 255, 255), 2);

                processedImage = primitivesImage; // Сохраняем результат в обработанное изображение
                imageBox2.Image = processedImage; // Отображаем его в imageBox2
            }
        }

        private bool isRectangle(Point[] points)
        {
            int delta = 10; // максимальное отклонение от прямого угла
            LineSegment2D[] edges = PointCollection.PolyLine(points, true);
            for (int i = 0; i < edges.Length; i++) // обход всех ребер контура
            {
                double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                if (angle < 90 - delta || angle > 90 + delta) // если угол непрямой
                {
                    return false;
                }
            }
            return true;
        }

        private void button_find_quadrilaterals_Click(object sender, EventArgs e)
        {
            if (regionsImage != null) // Используем сохраненное изображение с обнаруженными областями
            {
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                var primitivesImage = sourceImage.CopyBlank(); // Создаем "пустую" копию исходного изображения

                //double minArea = 100.0; // Минимально допустимая площадь для контуров

                int rectCount = 0;

                for (int i = 0; i < contours.Size; i++)
                {
                    var approxContour = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approxContour, CvInvoke.ArcLength(contours[i], true) * 0.05, true);

                    if (CvInvoke.ContourArea(approxContour, false) > minContourArea) // Проверка на площадь контура
                    {
                        if (approxContour.Size == 4 && isRectangle(approxContour.ToArray())) // Если контур содержит 4 точки и является прямоугольником
                        {
                            primitivesImage.Draw(CvInvoke.MinAreaRect(approxContour), new Bgr(Color.GreenYellow), 2); // Отрисовываем прямоугольник
                            rectCount ++;
                        }
                        //else // В противном случае просто рисуем аппроксимированный контур
                        //{
                        //    primitivesImage.Draw(approxContour.ToArray(), new Bgr(Color.Red), 2);
                        //}
                    }
                }

                string text = $"Rectangles: {rectCount}";
                Point textLocation = new Point(10, 30); // Позиция текста чуть ниже
                CvInvoke.PutText(primitivesImage, text, textLocation, FontFace.HersheyComplex, 0.7, new MCvScalar(255, 255, 255), 2);

                processedImage = primitivesImage; // Сохраняем результат в обработанное изображение
                imageBox2.Image = processedImage; // Отображаем его в imageBox2
            }
        }

        //4

        private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e)
        {
            thresholdValue = (double)numericUpDownThreshold.Value;
        }

        private void numericUpDownMinArea_ValueChanged(object sender, EventArgs e)
        {
            minContourArea = (double)numericUpDownMinArea.Value;
        }


    }
}
