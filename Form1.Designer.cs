

namespace WindowsFormsApp2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbRazbros = new System.Windows.Forms.TrackBar();
            this.lblRazbros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKryg = new System.Windows.Forms.Label();
            this.tbSchet = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tbTick = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSchet = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSchet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDirection.Location = new System.Drawing.Point(104, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 17);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.UseMnemonic = false;
            // 
            // tbRazbros
            // 
            this.tbRazbros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbRazbros.Location = new System.Drawing.Point(3, 99);
            this.tbRazbros.Maximum = 359;
            this.tbRazbros.Name = "tbRazbros";
            this.tbRazbros.Size = new System.Drawing.Size(163, 56);
            this.tbRazbros.TabIndex = 3;
            this.tbRazbros.Scroll += new System.EventHandler(this.tbRazbros_Scroll);
            // 
            // lblRazbros
            // 
            this.lblRazbros.AutoSize = true;
            this.lblRazbros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRazbros.Location = new System.Drawing.Point(70, 79);
            this.lblRazbros.Name = "lblRazbros";
            this.lblRazbros.Size = new System.Drawing.Size(0, 17);
            this.lblRazbros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс";
            // 
            // tbGraviton
            // 
            this.tbGraviton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbGraviton.Location = new System.Drawing.Point(3, 178);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(163, 56);
            this.tbGraviton.TabIndex = 7;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Первый круг";
            // 
            // lblKryg
            // 
            this.lblKryg.AutoSize = true;
            this.lblKryg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKryg.Location = new System.Drawing.Point(97, 158);
            this.lblKryg.Name = "lblKryg";
            this.lblKryg.Size = new System.Drawing.Size(0, 17);
            this.lblKryg.TabIndex = 11;
            // 
            // tbSchet
            // 
            this.tbSchet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSchet.Location = new System.Drawing.Point(4, 255);
            this.tbSchet.Maximum = 100;
            this.tbSchet.Name = "tbSchet";
            this.tbSchet.Size = new System.Drawing.Size(162, 56);
            this.tbSchet.TabIndex = 13;
            this.tbSchet.Value = 10;
            this.tbSchet.Scroll += new System.EventHandler(this.tbSchet_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(4, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Счётчик частиц";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.tbTick);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.lblSchet);
            this.splitContainer1.Panel2.Controls.Add(this.tbDirection);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbSchet);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lblKryg);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblRazbros);
            this.splitContainer1.Panel2.Controls.Add(this.lblDirection);
            this.splitContainer1.Panel2.Controls.Add(this.tbRazbros);
            this.splitContainer1.Panel2.Controls.Add(this.tbGraviton);
            this.splitContainer1.Size = new System.Drawing.Size(186, 570);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(0, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Параметры частиц";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(139, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 20;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(4, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Количество частиц";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(73, 436);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 21);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Музыка";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tbTick
            // 
            this.tbTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbTick.Location = new System.Drawing.Point(5, 333);
            this.tbTick.Maximum = 100;
            this.tbTick.Minimum = 10;
            this.tbTick.Name = "tbTick";
            this.tbTick.Size = new System.Drawing.Size(159, 56);
            this.tbTick.TabIndex = 20;
            this.tbTick.Value = 10;
            this.tbTick.Scroll += new System.EventHandler(this.tbTick_Scroll);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(4, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Задание";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 436);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Фон";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(3, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Цвет радара";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSchet
            // 
            this.lblSchet.AutoSize = true;
            this.lblSchet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSchet.Location = new System.Drawing.Point(66, 235);
            this.lblSchet.Name = "lblSchet";
            this.lblSchet.Size = new System.Drawing.Size(0, 17);
            this.lblSchet.TabIndex = 15;
            // 
            // tbDirection
            // 
            this.tbDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbDirection.Location = new System.Drawing.Point(6, 20);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(160, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(12, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Открыть/Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(204, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1000, 606);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSchet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbRazbros;
        private System.Windows.Forms.Label lblRazbros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKryg;
        private System.Windows.Forms.TrackBar tbSchet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSchet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar tbTick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

