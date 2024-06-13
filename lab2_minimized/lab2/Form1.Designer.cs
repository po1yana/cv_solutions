namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button_open_image = new System.Windows.Forms.Button();
            this.comboBox_Channel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Sepia = new System.Windows.Forms.Button();
            this.button_grey = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button_open_image2 = new System.Windows.Forms.Button();
            this.button_complement = new System.Windows.Forms.Button();
            this.button_xor = new System.Windows.Forms.Button();
            this.button_intersection = new System.Windows.Forms.Button();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.trackBarValue = new System.Windows.Forms.TrackBar();
            this.button_medianBlur = new System.Windows.Forms.Button();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_watercolor = new System.Windows.Forms.Button();
            this.trackBar_brightness = new System.Windows.Forms.TrackBar();
            this.trackBar_contrast = new System.Windows.Forms.TrackBar();
            this.trackBar_blend = new System.Windows.Forms.TrackBar();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.Brightness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cartoon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(497, 8);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(310, 239);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(497, 279);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(310, 239);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // button_open_image
            // 
            this.button_open_image.Location = new System.Drawing.Point(17, 8);
            this.button_open_image.Name = "button_open_image";
            this.button_open_image.Size = new System.Drawing.Size(86, 28);
            this.button_open_image.TabIndex = 3;
            this.button_open_image.Text = "Open image";
            this.button_open_image.UseVisualStyleBackColor = true;
            this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
            // 
            // comboBox_Channel
            // 
            this.comboBox_Channel.FormattingEnabled = true;
            this.comboBox_Channel.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox_Channel.Location = new System.Drawing.Point(17, 106);
            this.comboBox_Channel.Name = "comboBox_Channel";
            this.comboBox_Channel.Size = new System.Drawing.Size(86, 21);
            this.comboBox_Channel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цветовой канал";
            // 
            // button_Sepia
            // 
            this.button_Sepia.Location = new System.Drawing.Point(17, 144);
            this.button_Sepia.Name = "button_Sepia";
            this.button_Sepia.Size = new System.Drawing.Size(86, 25);
            this.button_Sepia.TabIndex = 6;
            this.button_Sepia.Text = "Sepia";
            this.button_Sepia.UseVisualStyleBackColor = true;
            this.button_Sepia.Click += new System.EventHandler(this.button_Sepia_Click);
            // 
            // button_grey
            // 
            this.button_grey.Location = new System.Drawing.Point(17, 53);
            this.button_grey.Name = "button_grey";
            this.button_grey.Size = new System.Drawing.Size(86, 29);
            this.button_grey.TabIndex = 7;
            this.button_grey.Text = "Grey";
            this.button_grey.UseVisualStyleBackColor = true;
            this.button_grey.Click += new System.EventHandler(this.button_grey_Click);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(8, 178);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(104, 50);
            this.trackBarBrightness.TabIndex = 8;
            this.trackBarBrightness.Value = 100;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brightness";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(8, 238);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Minimum = -100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(104, 50);
            this.trackBarContrast.TabIndex = 10;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contrast";
            // 
            // button_open_image2
            // 
            this.button_open_image2.Location = new System.Drawing.Point(17, 309);
            this.button_open_image2.Name = "button_open_image2";
            this.button_open_image2.Size = new System.Drawing.Size(75, 23);
            this.button_open_image2.TabIndex = 12;
            this.button_open_image2.Text = "Open image";
            this.button_open_image2.UseVisualStyleBackColor = true;
            this.button_open_image2.Click += new System.EventHandler(this.button_open_image2_Click);
            // 
            // button_complement
            // 
            this.button_complement.Location = new System.Drawing.Point(17, 346);
            this.button_complement.Name = "button_complement";
            this.button_complement.Size = new System.Drawing.Size(75, 23);
            this.button_complement.TabIndex = 13;
            this.button_complement.Text = "NOT";
            this.button_complement.UseVisualStyleBackColor = true;
            this.button_complement.Click += new System.EventHandler(this.button_complement_Click);
            // 
            // button_xor
            // 
            this.button_xor.Location = new System.Drawing.Point(17, 376);
            this.button_xor.Name = "button_xor";
            this.button_xor.Size = new System.Drawing.Size(75, 23);
            this.button_xor.TabIndex = 14;
            this.button_xor.Text = "XOR";
            this.button_xor.UseVisualStyleBackColor = true;
            this.button_xor.Click += new System.EventHandler(this.button_xor_Click);
            // 
            // button_intersection
            // 
            this.button_intersection.Location = new System.Drawing.Point(17, 406);
            this.button_intersection.Name = "button_intersection";
            this.button_intersection.Size = new System.Drawing.Size(75, 23);
            this.button_intersection.TabIndex = 15;
            this.button_intersection.Text = "AND";
            this.button_intersection.UseVisualStyleBackColor = true;
            this.button_intersection.Click += new System.EventHandler(this.button_intersection_Click);
            // 
            // trackBarHue
            // 
            this.trackBarHue.Location = new System.Drawing.Point(152, 25);
            this.trackBarHue.Maximum = 255;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(104, 50);
            this.trackBarHue.TabIndex = 16;
            this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Location = new System.Drawing.Point(152, 65);
            this.trackBarSaturation.Maximum = 255;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(104, 50);
            this.trackBarSaturation.TabIndex = 17;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
            // 
            // trackBarValue
            // 
            this.trackBarValue.Location = new System.Drawing.Point(152, 106);
            this.trackBarValue.Maximum = 255;
            this.trackBarValue.Name = "trackBarValue";
            this.trackBarValue.Size = new System.Drawing.Size(104, 50);
            this.trackBarValue.TabIndex = 18;
            this.trackBarValue.Scroll += new System.EventHandler(this.trackBarValue_Scroll);
            // 
            // button_medianBlur
            // 
            this.button_medianBlur.Location = new System.Drawing.Point(163, 171);
            this.button_medianBlur.Name = "button_medianBlur";
            this.button_medianBlur.Size = new System.Drawing.Size(75, 23);
            this.button_medianBlur.TabIndex = 19;
            this.button_medianBlur.Text = "Blur";
            this.button_medianBlur.UseVisualStyleBackColor = true;
            this.button_medianBlur.Click += new System.EventHandler(this.button_medianBlur_Click);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Location = new System.Drawing.Point(158, 297);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(52, 23);
            this.buttonApplyFilter.TabIndex = 33;
            this.buttonApplyFilter.Text = "Accept";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 353);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 353);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 379);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(23, 20);
            this.textBox6.TabIndex = 39;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(185, 379);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 20);
            this.textBox7.TabIndex = 40;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(214, 379);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(24, 20);
            this.textBox8.TabIndex = 41;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(158, 326);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(23, 20);
            this.textBox.TabIndex = 43;
            // 
            // button_watercolor
            // 
            this.button_watercolor.Location = new System.Drawing.Point(311, 152);
            this.button_watercolor.Name = "button_watercolor";
            this.button_watercolor.Size = new System.Drawing.Size(75, 23);
            this.button_watercolor.TabIndex = 44;
            this.button_watercolor.Text = "Watercolor";
            this.button_watercolor.UseVisualStyleBackColor = true;
            this.button_watercolor.Click += new System.EventHandler(this.button_watercolor_Click);
            // 
            // trackBar_brightness
            // 
            this.trackBar_brightness.Location = new System.Drawing.Point(293, 181);
            this.trackBar_brightness.Maximum = 50;
            this.trackBar_brightness.Name = "trackBar_brightness";
            this.trackBar_brightness.Size = new System.Drawing.Size(104, 50);
            this.trackBar_brightness.TabIndex = 45;
            this.trackBar_brightness.Scroll += new System.EventHandler(this.trackBar_brightness_Scroll);
            // 
            // trackBar_contrast
            // 
            this.trackBar_contrast.Location = new System.Drawing.Point(293, 211);
            this.trackBar_contrast.Maximum = 50;
            this.trackBar_contrast.Name = "trackBar_contrast";
            this.trackBar_contrast.Size = new System.Drawing.Size(104, 50);
            this.trackBar_contrast.TabIndex = 46;
            this.trackBar_contrast.Scroll += new System.EventHandler(this.trackBar_contrast_Scroll);
            // 
            // trackBar_blend
            // 
            this.trackBar_blend.Location = new System.Drawing.Point(293, 241);
            this.trackBar_blend.Maximum = 100;
            this.trackBar_blend.Name = "trackBar_blend";
            this.trackBar_blend.Size = new System.Drawing.Size(104, 50);
            this.trackBar_blend.TabIndex = 47;
            this.trackBar_blend.Scroll += new System.EventHandler(this.trackBar_blend_Scroll);
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(152, 219);
            this.trackBarThreshold.Maximum = 200;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(104, 50);
            this.trackBarThreshold.TabIndex = 0;
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Location = new System.Drawing.Point(322, 199);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(55, 13);
            this.Brightness.TabIndex = 48;
            this.Brightness.Text = "brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "contrast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "blend";
            // 
            // cartoon
            // 
            this.cartoon.AutoSize = true;
            this.cartoon.Location = new System.Drawing.Point(186, 241);
            this.cartoon.Name = "cartoon";
            this.cartoon.Size = new System.Drawing.Size(43, 13);
            this.cartoon.TabIndex = 51;
            this.cartoon.Text = "cartoon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "HSV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Hue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Saturation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 601);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cartoon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.trackBar_blend);
            this.Controls.Add(this.trackBar_contrast);
            this.Controls.Add(this.trackBar_brightness);
            this.Controls.Add(this.button_watercolor);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.button_medianBlur);
            this.Controls.Add(this.trackBarValue);
            this.Controls.Add(this.trackBarSaturation);
            this.Controls.Add(this.trackBarHue);
            this.Controls.Add(this.button_intersection);
            this.Controls.Add(this.button_xor);
            this.Controls.Add(this.button_complement);
            this.Controls.Add(this.button_open_image2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.button_grey);
            this.Controls.Add(this.button_Sepia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Channel);
            this.Controls.Add(this.button_open_image);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.ComboBox comboBox_Channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sepia;
        private System.Windows.Forms.Button button_grey;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_open_image2;
        private System.Windows.Forms.Button button_complement;
        private System.Windows.Forms.Button button_xor;
        private System.Windows.Forms.Button button_intersection;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.Button button_medianBlur;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_watercolor;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.TrackBar trackBar_contrast;
        private System.Windows.Forms.TrackBar trackBar_blend;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cartoon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

