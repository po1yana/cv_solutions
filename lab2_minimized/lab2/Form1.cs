using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace lab2
{

    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Hsv, byte> hsvImage;
        private Image<Bgr, byte> filteredImage;
        private Image<Bgr, byte> processedImage;
        private Image<Bgr, byte> sourceImage2;
        private Image<Bgr, byte> originalMaskImage;
        private Timer updateTimer;
        public Form1()
        {
            InitializeComponent();

            updateTimer = new Timer();
            updateTimer.Interval = 500;
            updateTimer.Tick += UpdateTimer_Tick;

            trackBarBrightness.Scroll += trackBarBrightness_Scroll_1;
            trackBarContrast.Scroll += trackBarContrast_Scroll;

            trackBarThreshold.ValueChanged += OnThresholdValueChanged;

        }

        private void button_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);

                hsvImage = sourceImage.Convert<Hsv, byte>();

                imageBox2.Image = filteredImage;
                imageBox2.SizeMode = PictureBoxSizeMode.Zoom;

                imageBox1.Image = sourceImage;
                imageBox1.SizeMode = PictureBoxSizeMode.Zoom;

                
                comboBox_Channel.SelectedIndexChanged += (obj, args) =>
                {
                    int selectedIndex = comboBox_Channel.SelectedIndex;

                    if (selectedIndex == 0) 
                    {
                        
                        imageBox2.Image = sourceImage.Split()[2];
                    }
                    else if (selectedIndex == 1) 
                    {
                       
                        imageBox2.Image = sourceImage.Split()[1];
                    }
                    else if (selectedIndex == 2) 
                    {
                       
                        imageBox2.Image = sourceImage.Split()[0];
                    }
                };
                UpdateProcessedImage();

                
            }

        }

        private void button_grey_Click(object sender, EventArgs e)
        {
            var grayImage = new Image<Gray, byte>(sourceImage.Size);

            for (int y = 0; y < sourceImage.Rows; y++)
            {
                for (int x = 0; x < sourceImage.Cols; x++)
                {
                    
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 0.587 *
                                                               sourceImage.Data[y, x, 1] + 0.114 * sourceImage.Data[y, x, 0]);
                }
            }

            imageBox2.Image = grayImage;
        }

        private void button_Sepia_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> sepiaImage = ApplySepiaFilter(sourceImage);
            imageBox2.Image = sepiaImage;
        } 
        
        private Image<Bgr, byte> ApplySepiaFilter(Image<Bgr, byte> sourceImage)
        {

            Image<Bgr, byte> sepiaImage = sourceImage.Clone();


            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {

                    Bgr pixel = sourceImage[y, x];


                    double blue = (0.272 * pixel.Blue) + (0.534 * pixel.Green) + (0.131 * pixel.Red);
                    double green = (0.349 * pixel.Blue) + (0.686 * pixel.Green) + (0.168 * pixel.Red);
                    double red = (0.393 * pixel.Blue) + (0.769 * pixel.Green) + (0.189 * pixel.Red);


                    blue = Math.Min(blue, 255);
                    green = Math.Min(green, 255);
                    red = Math.Min(red, 255);

                    sepiaImage[y, x] = new Bgr(blue, green, red);
                }
            }

            return sepiaImage;
        }

        //яркость и контраст + таймер
        private void trackBarBrightness_Scroll_1(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void UpdateProcessedImage()
        {

            if (sourceImage != null)
            {
                // Клонируем исходное изображение для обработки
                processedImage = sourceImage.Clone();

                // Применяем изменения яркости и контраста
                if (trackBarBrightness.Value != 0 || trackBarContrast.Value != 0)
                {
                    processedImage._EqualizeHist(); // Можете применить другие методы обработки здесь

                    // Применяем коррекцию гамма
                    double gamma = 1.0 + (trackBarContrast.Value / 100.0);
                    processedImage = ApplyGammaCorrection(processedImage, gamma);

                    // Применяем яркость
                    processedImage = ApplyBrightness(processedImage, trackBarBrightness.Value);
                }

                // Отобразить обработанное изображение в imageBox2
                imageBox2.Image = processedImage;
            }
        }

        private Image<Bgr, byte> ApplyGammaCorrection(Image<Bgr, byte> image, double gamma)
        {
            Image<Bgr, byte> correctedImage = image.CopyBlank();

            // Применяем коррекцию гамма к каждому каналу цвета (B, G, R) отдельно
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Получаем значения каналов цвета
                    byte blue = image.Data[y, x, 0];
                    byte green = image.Data[y, x, 1];
                    byte red = image.Data[y, x, 2];

                    // Применяем коррекцию гамма к каждому каналу цвета
                    byte correctedBlue = (byte)Math.Min(255, Math.Pow(blue / 255.0, 1.0 / gamma) * 255.0);
                    byte correctedGreen = (byte)Math.Min(255, Math.Pow(green / 255.0, 1.0 / gamma) * 255.0);
                    byte correctedRed = (byte)Math.Min(255, Math.Pow(red / 255.0, 1.0 / gamma) * 255.0);

                    // Записываем скорректированные значения каналов цвета
                    correctedImage.Data[y, x, 0] = correctedBlue;
                    correctedImage.Data[y, x, 1] = correctedGreen;
                    correctedImage.Data[y, x, 2] = correctedRed;
                }
            }

            return correctedImage;
        }

        private Image<Bgr, byte> ApplyBrightness(Image<Bgr, byte> image, int brightness)
        {
            return image.Add(new Bgr(brightness, brightness, brightness));
        }

        // Обработчик события изменения параметров яркости и контраста
        private void trackBarBrightnessContrast_Scroll(object sender, EventArgs e)
        {
            UpdateProcessedImage();
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Отключаем таймер
            updateTimer.Stop();

            // Обновляем изображение
            UpdateProcessedImage();
        }

        //логические операции 
        private void button_open_image2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage2 = new Image<Bgr, byte>(fileName);

                imageBox2.Image = sourceImage2;
            }
        }

        private void button_complement_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                // Выполняем логическую операцию дополнения
                Image<Bgr, byte> complementedImage = sourceImage.Not();
                imageBox2.Image = complementedImage;
            }
        }

        private void button_xor_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                // Выполняем логическую операцию исключения (XOR) с самим собой
                Image<Bgr, byte> xorImage = sourceImage.Xor(sourceImage2);
                imageBox2.Image = xorImage;
            }
        }

        private void button_intersection_Click(object sender, EventArgs e)
        {
            if (sourceImage != null )
            {
                // Выполняем логическую операцию пересечения
                Image<Bgr, byte> intersectionImage = sourceImage.And(sourceImage2);
                imageBox2.Image = intersectionImage;
            }
        }


        private void UpdateHSVImage()
        {
            if (hsvImage != null)
            {
                // Применяем изменения значений HSV
                Image<Hsv, byte> modifiedHsvImage = hsvImage.Copy();

                // Применяем изменения значений HSV
                modifiedHsvImage = modifiedHsvImage.Add(new Hsv(trackBarHue.Value, trackBarSaturation.Value, trackBarValue.Value));

                // Преобразуем обратно в Bgr формат для отображения
                Image<Bgr, byte> resultImage = modifiedHsvImage.Convert<Bgr, byte>();

                imageBox2.Image = resultImage;
            }
        }

        private void trackBarHue_Scroll(object sender, EventArgs e)
        {
            UpdateHSVImage();
        }

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            UpdateHSVImage();
        }

        private void trackBarValue_Scroll(object sender, EventArgs e)
        {
            UpdateHSVImage();
        }

        private void button_medianBlur_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                int kernelSize = 10; // Размер ядра медианного фильтра
                Image<Bgr, byte> medianBlurredImage = ApplyMedianBlur(sourceImage, kernelSize);
                imageBox2.Image = medianBlurredImage;
            }
        }

        private Image<Bgr, byte> ApplyMedianBlur(Image<Bgr, byte> sourceImage, int kernelSize)
        {
            int halfKernelSize = kernelSize / 2;
            Image<Bgr, byte> resultImage = sourceImage.CopyBlank();

            // Проходим по каждому пикселю изображения
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    // Создаем список для хранения значений каналов цвета в окрестности пикселя
                    List<byte> blueValues = new List<byte>();
                    List<byte> greenValues = new List<byte>();
                    List<byte> redValues = new List<byte>();

                    // Проходим по окрестности пикселя
                    for (int i = -halfKernelSize; i <= halfKernelSize; i++)
                    {
                        for (int j = -halfKernelSize; j <= halfKernelSize; j++)
                        {
                            // Получаем координаты пикселя в окрестности
                            int neighborX = x + j;
                            int neighborY = y + i;

                            // Проверяем, находится ли соседний пиксель в пределах изображения
                            if (neighborX >= 0 && neighborX < sourceImage.Width && neighborY >= 0 && neighborY < sourceImage.Height)
                            {
                                // Получаем значения цветового канала соседнего пикселя
                                Bgr pixel = sourceImage[neighborY, neighborX];
                                blueValues.Add((byte)pixel.Blue);
                                greenValues.Add((byte)pixel.Green);
                                redValues.Add((byte)pixel.Red);
                            }
                        }
                    }

                    // Находим медианное значение для каждого канала цвета в окрестности и применяем его к текущему пикселю
                    blueValues.Sort();
                    greenValues.Sort();
                    redValues.Sort();
                    byte medianBlue = blueValues[blueValues.Count / 2];
                    byte medianGreen = greenValues[greenValues.Count / 2];
                    byte medianRed = redValues[redValues.Count / 2];
                    resultImage[y, x] = new Bgr(medianBlue, medianGreen, medianRed);
                }
            }

            return resultImage;
        }

        //оконного фильтра (8)
        

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                // Получаем значения из textBox'ов и создаем матрицу фильтра
                float[,] filterMatrix = new float[3, 3];
                filterMatrix[0, 0] = float.Parse(textBox.Text);
                filterMatrix[0, 1] = float.Parse(textBox1.Text);
                filterMatrix[0, 2] = float.Parse(textBox2.Text);
                filterMatrix[1, 0] = float.Parse(textBox3.Text);
                filterMatrix[1, 1] = float.Parse(textBox4.Text);
                filterMatrix[1, 2] = float.Parse(textBox5.Text);
                filterMatrix[2, 0] = float.Parse(textBox6.Text);
                filterMatrix[2, 1] = float.Parse(textBox7.Text);
                filterMatrix[2, 2] = float.Parse(textBox8.Text);

                // Преобразование матрицы фильтра в одномерный массив типа float
                float[] filterArray = new float[9];
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        filterArray[index] = filterMatrix[i, j];
                        index++;
                    }
                }

                // Преобразование одномерного массива в объект Mat
                Mat kernel = new Mat(3, 3, DepthType.Cv32F, 1);
                kernel.SetTo(filterArray);

                // Применяем фильтр к изображению
                Image<Bgr, byte> filteredImage = sourceImage.CopyBlank();
                CvInvoke.Filter2D(sourceImage, filteredImage, kernel, new Point(-1, -1));

                // Выводим изображение с примененным фильтром в imageBox2
                imageBox2.Image = filteredImage;
            }
        }
        //9
        private void button_watercolor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                originalMaskImage = new Image<Bgr, byte>(fileName);

                // Применение маски к исходному изображению и отображение в imageBox2
                ApplyWatercolorFilter();
            }
        }

        private void trackBar_brightness_Scroll(object sender, EventArgs e)
        {
            AdjustBrightness(trackBar_brightness.Value);
        }

        private void trackBar_contrast_Scroll(object sender, EventArgs e)
        {
            AdjustContrast(trackBar_contrast.Value / 10.0);
        }

        private void trackBar_blend_Scroll(object sender, EventArgs e)
        {
            BlendImages(trackBar_blend.Value / 100.0);
        }

        private void AdjustBrightness(int value)
        {
            if (filteredImage != null)
            {
                // Создание копии изображения, с которой будем работать
                Image<Bgr, byte> bgrImage = filteredImage.Clone();

                // Применение изменения яркости к каждому пикселю
                for (int y = 0; y < bgrImage.Height; y++)
                {
                    for (int x = 0; x < bgrImage.Width; x++)
                    {
                        Bgr pixel = bgrImage[y, x];
                        // Изменение яркости для каждого канала (BGR)
                        bgrImage[y, x] = new Bgr(ClipValue(pixel.Blue + value), ClipValue(pixel.Green + value), ClipValue(pixel.Red + value));
                    }
                }

                // Обновление изображения в imageBox2
                imageBox2.Image = bgrImage;
            }
        }

        private void AdjustContrast(double value)
        {
            if (filteredImage != null)
            {
                // Создание копии изображения, с которой будем работать
                Image<Bgr, byte> bgrImage = filteredImage.Clone();

                // Применение изменения контраста к каждому пикселю
                for (int y = 0; y < bgrImage.Height; y++)
                {
                    for (int x = 0; x < bgrImage.Width; x++)
                    {
                        Bgr pixel = bgrImage[y, x];
                        // Изменение контраста для каждого канала (BGR)
                        bgrImage[y, x] = new Bgr(ClipValue((pixel.Blue - 127) * value + 127), ClipValue((pixel.Green - 127) * value + 127), ClipValue((pixel.Red - 127) * value + 127));
                    }
                }

                // Обновление изображения в imageBox2
                imageBox2.Image = bgrImage;
            }
        }

        private byte ClipValue(double value)
        {
            return (byte)Math.Max(0, Math.Min(255, value));
        }



        private void BlendImages(double blendValue)
        {
            if (originalMaskImage != null)
            {
                // Применение смешивания изображений с помощью метода AddWeighted
                CvInvoke.AddWeighted(sourceImage, blendValue, originalMaskImage, 1 - blendValue, 0, filteredImage);
                // Отображение результирующего изображения
                imageBox2.Image = filteredImage;
            }
        }

        private void ApplyWatercolorFilter()
        {
            if (sourceImage != null && originalMaskImage != null)
            {
                // Применение маски к исходному изображению
                filteredImage = new Image<Bgr, byte>(sourceImage.Size);
                CvInvoke.AddWeighted(sourceImage, 0.5, originalMaskImage, 0.5, 0, filteredImage);

                // Отображение фильтрованного изображения в imageBox2
                imageBox2.Image = filteredImage;
            }
        }

       


        //10
        private void OnThresholdValueChanged(object sender, EventArgs e)
        {
            ApplyCartoonFilter(trackBarThreshold.Value); // Переприменяем фильтр при изменении порога
        }

        private void ApplyCartoonFilter(int thresholdValue)
        {
            if (sourceImage != null)
            {
                // Конвертируем в градации серого и применяем медианный фильтр для сглаживания
                Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>().PyrDown().PyrUp();

                // Применяем медианный фильтр
                grayImage = grayImage.SmoothMedian(9);

                // Применяем бинаризацию с новым значением порога
                grayImage = grayImage.ThresholdBinary(new Gray(thresholdValue), new Gray(255));

                // Применяем контурный фильтр
                Image<Gray, byte> cannyEdges = grayImage.Canny(100, 50);

                // Применяем дилатацию к краям
                cannyEdges = cannyEdges.Dilate(3);

                // Создаем маску для границ
                Image<Gray, byte> mask = cannyEdges.Convert<Gray, byte>().Not();

                // Применяем маску к исходному изображению
                Image<Bgr, byte> cartoonImage = sourceImage.And(new Bgr(255, 255, 255), mask);

                // Отображаем изображение с примененным фильтром на imageBox2
                imageBox2.Image = cartoonImage;
            }
        }







    }

}
