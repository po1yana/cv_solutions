namespace lab3
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
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.button_scale = new System.Windows.Forms.Button();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_process = new System.Windows.Forms.Button();
            this.textBox_shift = new System.Windows.Forms.TextBox();
            this.textBox_angle = new System.Windows.Forms.TextBox();
            this.textBox_centerX = new System.Windows.Forms.TextBox();
            this.textBox_centerY = new System.Windows.Forms.TextBox();
            this.button_process_image = new System.Windows.Forms.Button();
            this.button_mirror = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_projection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(154, 9);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(300, 263);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseClick);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(460, 9);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(328, 263);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // button_open_image
            // 
            this.button_open_image.Location = new System.Drawing.Point(30, 18);
            this.button_open_image.Name = "button_open_image";
            this.button_open_image.Size = new System.Drawing.Size(84, 23);
            this.button_open_image.TabIndex = 3;
            this.button_open_image.Text = "Open image";
            this.button_open_image.UseVisualStyleBackColor = true;
            this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.DecimalPlaces = 1;
            this.numericUpDown_width.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_width.Location = new System.Drawing.Point(55, 89);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_width.TabIndex = 4;
            // 
            // button_scale
            // 
            this.button_scale.Location = new System.Drawing.Point(30, 59);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(84, 23);
            this.button_scale.TabIndex = 5;
            this.button_scale.Text = "Scaling";
            this.button_scale.UseVisualStyleBackColor = true;
            this.button_scale.Click += new System.EventHandler(this.button_scale_Click);
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.DecimalPlaces = 1;
            this.numericUpDown_height.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_height.Location = new System.Drawing.Point(55, 115);
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_height.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "H";
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(30, 151);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(84, 23);
            this.button_process.TabIndex = 9;
            this.button_process.Text = "Shearing";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // textBox_shift
            // 
            this.textBox_shift.Location = new System.Drawing.Point(30, 180);
            this.textBox_shift.Name = "textBox_shift";
            this.textBox_shift.Size = new System.Drawing.Size(84, 20);
            this.textBox_shift.TabIndex = 10;
            // 
            // textBox_angle
            // 
            this.textBox_angle.Location = new System.Drawing.Point(75, 252);
            this.textBox_angle.Name = "textBox_angle";
            this.textBox_angle.Size = new System.Drawing.Size(39, 20);
            this.textBox_angle.TabIndex = 12;
            // 
            // textBox_centerX
            // 
            this.textBox_centerX.Location = new System.Drawing.Point(75, 278);
            this.textBox_centerX.Name = "textBox_centerX";
            this.textBox_centerX.Size = new System.Drawing.Size(39, 20);
            this.textBox_centerX.TabIndex = 13;
            // 
            // textBox_centerY
            // 
            this.textBox_centerY.Location = new System.Drawing.Point(75, 304);
            this.textBox_centerY.Name = "textBox_centerY";
            this.textBox_centerY.Size = new System.Drawing.Size(40, 20);
            this.textBox_centerY.TabIndex = 14;
            // 
            // button_process_image
            // 
            this.button_process_image.Location = new System.Drawing.Point(30, 223);
            this.button_process_image.Name = "button_process_image";
            this.button_process_image.Size = new System.Drawing.Size(84, 23);
            this.button_process_image.TabIndex = 15;
            this.button_process_image.Text = "Rotation";
            this.button_process_image.UseVisualStyleBackColor = true;
            this.button_process_image.Click += new System.EventHandler(this.button_process_image_Click);
            // 
            // button_mirror
            // 
            this.button_mirror.Location = new System.Drawing.Point(30, 346);
            this.button_mirror.Name = "button_mirror";
            this.button_mirror.Size = new System.Drawing.Size(84, 23);
            this.button_mirror.TabIndex = 16;
            this.button_mirror.Text = "Mirror";
            this.button_mirror.UseVisualStyleBackColor = true;
            this.button_mirror.Click += new System.EventHandler(this.button_mirror_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "degrees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "center X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "center Y";
            // 
            // button_projection
            // 
            this.button_projection.Location = new System.Drawing.Point(39, 387);
            this.button_projection.Name = "button_projection";
            this.button_projection.Size = new System.Drawing.Size(75, 23);
            this.button_projection.TabIndex = 20;
            this.button_projection.Text = "focus";
            this.button_projection.UseVisualStyleBackColor = true;
            this.button_projection.Click += new System.EventHandler(this.button_projection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_projection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_mirror);
            this.Controls.Add(this.button_process_image);
            this.Controls.Add(this.textBox_centerY);
            this.Controls.Add(this.textBox_centerX);
            this.Controls.Add(this.textBox_angle);
            this.Controls.Add(this.textBox_shift);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_height);
            this.Controls.Add(this.button_scale);
            this.Controls.Add(this.numericUpDown_width);
            this.Controls.Add(this.button_open_image);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.TextBox textBox_shift;
        private System.Windows.Forms.TextBox textBox_angle;
        private System.Windows.Forms.TextBox textBox_centerX;
        private System.Windows.Forms.TextBox textBox_centerY;
        private System.Windows.Forms.Button button_process_image;
        private System.Windows.Forms.Button button_mirror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_projection;
    }
}

