namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nextBtn = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThanks = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(26, 349);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(201, 41);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Следующий вопрос";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(72, 22);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос";
            this.lblQuestion.Visible = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1.Location = new System.Drawing.Point(26, 66);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(99, 26);
            this.rb1.TabIndex = 16;
            this.rb1.TabStop = true;
            this.rb1.Text = "блабла1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Visible = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb3.Location = new System.Drawing.Point(26, 128);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(99, 26);
            this.rb3.TabIndex = 15;
            this.rb3.TabStop = true;
            this.rb3.Text = "блабла3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.Visible = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb5.Location = new System.Drawing.Point(26, 192);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(99, 26);
            this.rb5.TabIndex = 14;
            this.rb5.TabStop = true;
            this.rb5.Text = "блабла5";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.Visible = false;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb7.Location = new System.Drawing.Point(26, 256);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(99, 26);
            this.rb7.TabIndex = 13;
            this.rb7.TabStop = true;
            this.rb7.Text = "блабла7";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.Visible = false;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb8.Location = new System.Drawing.Point(26, 292);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(99, 26);
            this.rb8.TabIndex = 12;
            this.rb8.TabStop = true;
            this.rb8.Text = "блабла8";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.Visible = false;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb6.Location = new System.Drawing.Point(26, 224);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(99, 26);
            this.rb6.TabIndex = 11;
            this.rb6.TabStop = true;
            this.rb6.Text = "блабла6";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.Visible = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb4.Location = new System.Drawing.Point(26, 160);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(99, 26);
            this.rb4.TabIndex = 10;
            this.rb4.TabStop = true;
            this.rb4.Text = "блабла4";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.Visible = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2.Location = new System.Drawing.Point(26, 98);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(99, 26);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "блабла2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb4);
            this.panel1.Controls.Add(this.rb5);
            this.panel1.Controls.Add(this.rb6);
            this.panel1.Controls.Add(this.rb7);
            this.panel1.Controls.Add(this.rb8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 431);
            this.panel1.TabIndex = 17;
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(301, 176);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(156, 42);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Начать опрос";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.bd12d7ff0ccd612673dd1a6988158bcd_002;
            this.pictureBox1.Location = new System.Drawing.Point(568, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThanks.Location = new System.Drawing.Point(23, 368);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(699, 25);
            this.lblThanks.TabIndex = 19;
            this.lblThanks.Text = "Опрос окончен! Благодарим за потраченное время! Всего Вам доброго =)";
            this.lblThanks.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._1_140606141104455;
            this.pictureBox2.Location = new System.Drawing.Point(126, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(606, 333);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(353, 463);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(116, 39);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "Выйти";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Visible = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(851, 514);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Анкета ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button startBtn;
    }
}

