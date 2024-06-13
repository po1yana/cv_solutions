using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Bgr, byte> processedImage;
        private PointF[] srcPoints; // Точки для исходного изображения
        private int pointsSelected = 0;


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
                srcPoints = null;
                pointsSelected = 0;
            }
        }
        // 1
        private void button_scale_Click(object sender, EventArgs e)
        {
            // Проверяем, что исходное изображение загружено
            if (sourceImage != null)
            {
                // Коэффициенты масштабирования
                float sX = (float)numericUpDown_width.Value;
                float sY = (float)numericUpDown_height.Value;

                // Создание нового изображения с учетом масштабирования
                int newWidth = (int)(sourceImage.Width * sX);
                int newHeight = (int)(sourceImage.Height * sY);
                var newImage = new Image<Bgr, byte>(newWidth, newHeight);

                // Билинейная фильтрация
                for (int x = 0; x < newWidth; x++)
                {
                    for (int y = 0; y < newHeight; y++)
                    {
                        // Координаты исходного изображения, округленные до ближайших нижних значений
                        int floorX = (int)Math.Floor(x / sX);
                        int floorY = (int)Math.Floor(y / sY);

                        // Дистанция от ближайших точек исходного изображения до искомой
                        float ratioX = x / sX - floorX;
                        float ratioY = y / sY - floorY;

                        // Координаты ближайших точек на исходном изображении
                        int baseX = Math.Min(floorX, sourceImage.Width - 2);
                        int baseY = Math.Min(floorY, sourceImage.Height - 2);

                        // Расчет значений для билинейной фильтрации
                        float invRatioX = 1 - ratioX;
                        float invRatioY = 1 - ratioY;

                        // Вычисление нового цвета пикселя
                        Bgr newVal = new Bgr(
                            (sourceImage[baseY, baseX].Blue * invRatioX + sourceImage[baseY, baseX + 1].Blue * ratioX) * invRatioY +
                            (sourceImage[baseY + 1, baseX].Blue * invRatioX + sourceImage[baseY + 1, baseX + 1].Blue * ratioX) * ratioY,

                            (sourceImage[baseY, baseX].Green * invRatioX + sourceImage[baseY, baseX + 1].Green * ratioX) * invRatioY +
                            (sourceImage[baseY + 1, baseX].Green * invRatioX + sourceImage[baseY + 1, baseX + 1].Green * ratioX) * ratioY,

                            (sourceImage[baseY, baseX].Red * invRatioX + sourceImage[baseY, baseX + 1].Red * ratioX) * invRatioY +
                            (sourceImage[baseY + 1, baseX].Red * invRatioX + sourceImage[baseY + 1, baseX + 1].Red * ratioX) * ratioY
                        );

                        // Установка значения в новое изображение
                        newImage[y, x] = newVal;
                    }
                }

                // Отображение обработанного изображения во втором ImageBox
                processedImage = newImage;
                imageBox2.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Сначала откройте изображение!");
            }
        }


        //2
        private void button_process_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                MessageBox.Show("Откройте изображение сначала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textBox_shift.Text, out float shift))
            {
                MessageBox.Show("Введите корректное значение сдвига.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            processedImage = new Image<Bgr, byte>(sourceImage.Width, sourceImage.Height);

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    int newX = (int)(x + shift * (sourceImage.Height - y));
                    int newY = y;

                    if (newX >= 0 && newX < sourceImage.Width)
                    {
                        processedImage[newY, newX] = sourceImage[y, x];
                    }
                }
            }

            imageBox2.Image = processedImage;
        }


        //3
        private void button_process_image_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала выберите изображение");
                return;
            }

            // Получаем параметры из формы
            double angle;
            int centerX, centerY;

            if (!double.TryParse(textBox_angle.Text, out angle))
            {
                MessageBox.Show("Введите корректный угол");
                return;
            }

            if (!int.TryParse(textBox_centerX.Text, out centerX) || !int.TryParse(textBox_centerY.Text, out centerY))
            {
                MessageBox.Show("Введите корректные координаты центра вращения");
                return;
            }

            // Выполняем поворот изображения
            processedImage = RotateImage(sourceImage, angle, centerX, centerY);

            // Отображаем обработанное изображение
            imageBox2.Image = processedImage;
        }

        private Image<Bgr, byte> RotateImage(Image<Bgr, byte> image, double angle, int centerX, int centerY)
        {
            // Создаем пустое изображение для повернутого изображения
            Image<Bgr, byte> rotatedImage = new Image<Bgr, byte>(image.Width, image.Height);

            // Переводим угол в радианы
            double radians = angle * Math.PI / 180.0;

            // Инвертируем угол для обратного поворота
            double invRadians = -radians;

            // Проходим по каждому пикселю в повернутом изображении
            for (int y = 0; y < rotatedImage.Height; y++)
            {
                for (int x = 0; x < rotatedImage.Width; x++)
                {
                    // Вычисляем координаты в исходном изображении для текущего пикселя в повернутом изображении
                    double srcX = (x - centerX) * Math.Cos(invRadians) - (y - centerY) * Math.Sin(invRadians) + centerX;
                    double srcY = (x - centerX) * Math.Sin(invRadians) + (y - centerY) * Math.Cos(invRadians) + centerY;

                    // Получаем координаты базовых точек
                    int baseX = (int)Math.Floor(srcX);
                    int baseY = (int)Math.Floor(srcY);

                    // Получаем относительные расстояния от базовой точки до целевой точки
                    double ratioX = srcX - baseX;
                    double ratioY = srcY - baseY;

                    // Учитываем выход за границы исходного изображения
                    if (baseX < 0 || baseY < 0 || baseX >= image.Width - 1 || baseY >= image.Height - 1)
                        continue;

                    // Получаем значения цветов изображения в базовых точках
                    Bgr c1 = image[baseY, baseX];
                    Bgr c2 = image[baseY, baseX + 1];
                    Bgr c3 = image[baseY + 1, baseX];
                    Bgr c4 = image[baseY + 1, baseX + 1];

                    // Применяем билинейную интерполяцию
                    Bgr interpolatedColor = BilinearInterpolation(c1, c2, c3, c4, ratioX, ratioY);

                    // Устанавливаем цвет пикселя в повернутом изображении
                    rotatedImage[y, x] = interpolatedColor;
                }
            }

            return rotatedImage;
        }

        private Bgr BilinearInterpolation(Bgr c1, Bgr c2, Bgr c3, Bgr c4, double ratioX, double ratioY)
        {
            // Применяем формулу билинейной интерполяции для каждого канала цвета
            double blue = (1 - ratioX) * (1 - ratioY) * c1.Blue + ratioX * (1 - ratioY) * c2.Blue +
                          (1 - ratioX) * ratioY * c3.Blue + ratioX * ratioY * c4.Blue;
            double green = (1 - ratioX) * (1 - ratioY) * c1.Green + ratioX * (1 - ratioY) * c2.Green +
                           (1 - ratioX) * ratioY * c3.Green + ratioX * ratioY * c4.Green;
            double red = (1 - ratioX) * (1 - ratioY) * c1.Red + ratioX * (1 - ratioY) * c2.Red +
                         (1 - ratioX) * ratioY * c3.Red + ratioX * ratioY * c4.Red;

            // Возвращаем результирующий цвет
            return new Bgr(blue, green, red);
        }

        //4

        private void button_mirror_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                processedImage = sourceImage.Clone(); // создаем копию исходного изображения

                // Отражение по горизонтали
                for (int y = 0; y < processedImage.Height; y++)
                {
                    for (int x = 0; x < processedImage.Width / 2; x++)
                    {
                        var temp = processedImage.Data[y, x, 0];
                        processedImage.Data[y, x, 0] = processedImage.Data[y, processedImage.Width - 1 - x, 0];
                        processedImage.Data[y, processedImage.Width - 1 - x, 0] = temp;

                        temp = processedImage.Data[y, x, 1];
                        processedImage.Data[y, x, 1] = processedImage.Data[y, processedImage.Width - 1 - x, 1];
                        processedImage.Data[y, processedImage.Width - 1 - x, 1] = temp;

                        temp = processedImage.Data[y, x, 2];
                        processedImage.Data[y, x, 2] = processedImage.Data[y, processedImage.Width - 1 - x, 2];
                        processedImage.Data[y, processedImage.Width - 1 - x, 2] = temp;
                    }
                }

                // Обновляем imageBox2 с отраженным изображением
                imageBox2.Image = processedImage;
            }
        }


        //6

        private void button_projection_Click(object sender, EventArgs e)
        {
            if (srcPoints == null || srcPoints.Length != 4)
            {
                MessageBox.Show("Выберите четыре точки для проекции на плоскость.");
                return;
            }

            // Определение точек на плоскости
            var destPoints = new PointF[]
            {
        new PointF(0, 0),
        new PointF(sourceImage.Width - 1, 0),
        new PointF(sourceImage.Width - 1, sourceImage.Height - 1),
        new PointF(0, sourceImage.Height - 1)
            };

            // Получение матрицы гомографической проекции
            var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);

            // Проекция изображения
            var destImage = new Image<Bgr, byte>(sourceImage.Size);
            CvInvoke.WarpPerspective(sourceImage, destImage, homographyMatrix, destImage.Size);

            // Отображение результата во втором ImageBox
            imageBox2.Image = destImage;
        }

        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)(e.Location.X / imageBox1.ZoomScale);
            int y = (int)(e.Location.Y / imageBox1.ZoomScale);

            // Рисование круга на изображении для обозначения точки
            Point center = new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Blue).MCvScalar;
            CvInvoke.Circle(sourceImage, center, radius, color, thickness);

            // Добавление точки к массиву srcPoints
            if (srcPoints == null)
                srcPoints = new PointF[4];

            srcPoints[pointsSelected] = new PointF(x, y);
            pointsSelected++;

            if (pointsSelected == 4)
            {
                // Если выбраны все 4 точки, выполняем проекцию
                button_projection_Click(sender, e);
                pointsSelected = 0;
            }
        }

    }
}
