using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point;//первая точка
        Cyrcle cyrcle;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);//Привязка изображения
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            };
            emitters.Add(this.emitter);

            point = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2
            };

            cyrcle = new Cyrcle
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2
            };

            emitter.impactPoints.Add(cyrcle);
            emitter.impactPoints.Add(point);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = $"{emitter.ParticlesPerTick}";
            cyrcle.par.Clear();
            emitter.UpdateState();//обновление эмиттера
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);//Очистка экрана, заливка формы в чёрный цвет
                emitter.Render(g); //Рендеринг системы через эмиттер
            }
            picDisplay.Invalidate();//обновление формы
        }

        //Фиксация положения мыши
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //положение мыши в переменные для хранения положения мыши
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
                cyrcle.X = e.X;
                cyrcle.Y = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbRazbros_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbRazbros.Value;
            lblRazbros.Text = $"{tbRazbros.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point.Power = tbGraviton.Value;
            lblKryg.Text = $"{tbGraviton.Value}°";
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Нажимаем на левую кнопку мыши
            {
                emitter.impactPoints.Add(//Добавляем счётчик
                    new Schetchik
                    {
                        X = e.X,
                        Y = e.Y,
                        radius = tbSchet.Value,
                    }
                );
            }
            else if (e.Button == MouseButtons.Right)//Нажимаем на праваую кнопку мыши
            {
                foreach (var point in emitter.impactPoints.ToArray())
                {
                    if (point is Schetchik)//если круг - счётчик
                    {
                        Schetchik sc = point as Schetchik;
                        float gX = sc.X - e.X;
                        float gY = sc.Y - e.Y;
                        double r = Math.Sqrt(gX * gX + gY * gY);
                        if (r <= sc.radius)
                        {
                            emitter.impactPoints.Remove(point);//Удаляем счётчик
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                foreach (var point in emitter.impactPoints.ToArray())
                {
                    if (point is Schetchik)//если круг - счётчик
                    {
                        Schetchik sc = point as Schetchik;
                        float gX = sc.X - e.X;
                        float gY = sc.Y - e.Y;
                        double r = Math.Sqrt(gX * gX + gY * gY);
                        if (r <= sc.radius)
                        {
                            sc.schet = 0;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = splitContainer1.Panel2Collapsed ? false : true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void tbSchet_Scroll(object sender, EventArgs e)
        {
            lblSchet.Text = $"{tbSchet.Value}";
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                cyrcle.Raduis += 5;
                if (cyrcle.Raduis > 200)
                {
                    cyrcle.Raduis = 30;
                }
            }
            else if (e.Delta < 0)
            {
                cyrcle.Raduis -= 5;
                if (cyrcle.Raduis < 0)
                {
                    cyrcle.Raduis = 30;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cyrcle.col = colorDialog1.Color;
            button2.BackColor = cyrcle.col;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                Random r = new Random();
                this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                button3.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            }
            else
            {
                this.BackColor = DefaultBackColor;
                button3.BackColor = DefaultBackColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Реализовать точку-счетчик частиц, попадая в которую частица умирает, а на точке пишется сколько частиц она уже собрала." +
                "\n•при клике мышкой добавлять новый счетчик" +
                "\n•при клике правой кнопкой мыши, удалять счетчик" +
                "\n•при увеличении счетчика менять насыщеность цвета счетчика" +
                "\n\nРеализовать точку-область а-ля радар" +
                "\n•все частицы, попадающие в заданную область должны подсвечиваться как-то цветом" +
                "\n•в центре необходимо писать количество частиц, оказавшихся в зоне действия радара" +
                "\n•используя колесико мыши менять размеры области", "Задания");
        }
        public SoundPlayer sp;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            sp.Stream = Properties.Resources._1;
            CheckBox checkBox1 = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox1.Checked)
            {
                sp.Play();
            }
            else
            {
                sp.Stop();

            }
        }

        private void tbTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbTick.Value;
            if (tbTick.Value == 0)
            {
                emitter.ParticlesPerTick = 1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"{emitter.ParticlesPerTick}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

