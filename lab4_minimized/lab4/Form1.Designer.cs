namespace lab4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_remove_noise = new System.Windows.Forms.Button();
            this.button_detect_regions = new System.Windows.Forms.Button();
            this.button_find_contours = new System.Windows.Forms.Button();
            this.button_find_primitives = new System.Windows.Forms.Button();
            this.button_find_quadrilaterals = new System.Windows.Forms.Button();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinArea = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(166, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(297, 272);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(469, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(319, 272);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_open_image_Click);
            // 
            // button_remove_noise
            // 
            this.button_remove_noise.Location = new System.Drawing.Point(34, 76);
            this.button_remove_noise.Name = "button_remove_noise";
            this.button_remove_noise.Size = new System.Drawing.Size(98, 23);
            this.button_remove_noise.TabIndex = 4;
            this.button_remove_noise.Text = "remove noise";
            this.button_remove_noise.UseVisualStyleBackColor = true;
            this.button_remove_noise.Click += new System.EventHandler(this.button_remove_noise_Click);
            // 
            // button_detect_regions
            // 
            this.button_detect_regions.Location = new System.Drawing.Point(34, 105);
            this.button_detect_regions.Name = "button_detect_regions";
            this.button_detect_regions.Size = new System.Drawing.Size(98, 23);
            this.button_detect_regions.TabIndex = 5;
            this.button_detect_regions.Text = "detect regions";
            this.button_detect_regions.UseVisualStyleBackColor = true;
            this.button_detect_regions.Click += new System.EventHandler(this.button_detect_regions_Click);
            // 
            // button_find_contours
            // 
            this.button_find_contours.Location = new System.Drawing.Point(43, 173);
            this.button_find_contours.Name = "button_find_contours";
            this.button_find_contours.Size = new System.Drawing.Size(75, 23);
            this.button_find_contours.TabIndex = 6;
            this.button_find_contours.Text = "contours";
            this.button_find_contours.UseVisualStyleBackColor = true;
            this.button_find_contours.Click += new System.EventHandler(this.button_find_contours_Click);
            // 
            // button_find_primitives
            // 
            this.button_find_primitives.Location = new System.Drawing.Point(22, 222);
            this.button_find_primitives.Name = "button_find_primitives";
            this.button_find_primitives.Size = new System.Drawing.Size(122, 23);
            this.button_find_primitives.TabIndex = 7;
            this.button_find_primitives.Text = "primitives triangles";
            this.button_find_primitives.UseVisualStyleBackColor = true;
            this.button_find_primitives.Click += new System.EventHandler(this.button_find_primitives_Click);
            // 
            // button_find_quadrilaterals
            // 
            this.button_find_quadrilaterals.Location = new System.Drawing.Point(22, 251);
            this.button_find_quadrilaterals.Name = "button_find_quadrilaterals";
            this.button_find_quadrilaterals.Size = new System.Drawing.Size(122, 23);
            this.button_find_quadrilaterals.TabIndex = 8;
            this.button_find_quadrilaterals.Text = "primitives rectangles";
            this.button_find_quadrilaterals.UseVisualStyleBackColor = true;
            this.button_find_quadrilaterals.Click += new System.EventHandler(this.button_find_quadrilaterals_Click);
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(43, 289);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownThreshold.TabIndex = 9;
            this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.numericUpDownThreshold_ValueChanged);
            // 
            // numericUpDownMinArea
            // 
            this.numericUpDownMinArea.Location = new System.Drawing.Point(43, 315);
            this.numericUpDownMinArea.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinArea.Name = "numericUpDownMinArea";
            this.numericUpDownMinArea.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownMinArea.TabIndex = 10;
            this.numericUpDownMinArea.ValueChanged += new System.EventHandler(this.numericUpDownMinArea_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownMinArea);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.button_find_quadrilaterals);
            this.Controls.Add(this.button_find_primitives);
            this.Controls.Add(this.button_find_contours);
            this.Controls.Add(this.button_detect_regions);
            this.Controls.Add(this.button_remove_noise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_remove_noise;
        private System.Windows.Forms.Button button_detect_regions;
        private System.Windows.Forms.Button button_find_contours;
        private System.Windows.Forms.Button button_find_primitives;
        private System.Windows.Forms.Button button_find_quadrilaterals;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDownMinArea;
    }
}

