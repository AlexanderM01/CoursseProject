using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Particle //Класс частиц
    {
        public int Radius; //Радиус частицы
        public float X; //X координата положения частицы в пространстве
        public float Y; //Y координата положения частицы в пространстве

        public float SpeedX; //Скорость пермещения по X
        public float SpeedY; //Скорость пермещения по Y

        public float Life; // здоровье частицы
        public static Random rand = new Random();//Генератор случайных чисел

        public Color FromColor;
        public Color ToColor;

        public Color color1;
        public Color color2;

        public Particle() //Констуруктор, который создаёт кастомную частицу
        {
            var direction = (double)rand.Next(360);//
            var speed = 1 + rand.Next(10);// Скорость от 1 до 11

            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
            Radius = 2 + rand.Next(10);// Радиус от 2 до 12
            Life = 20 + rand.Next(100);// Запас здоровья от 20 до 120
        }

        //virtual чтобы переопределять функцию
        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);//коэф прозрачности от 0 до 1.0
            int alpha = (int)(k * 255);//значение альфа от 0 до 255
                                       //задание прозрачности
            var color = Color.FromArgb(alpha, Color.Black);//привязываем к увету прозрачность

            var b = new SolidBrush(color); //Кисть для рисования
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);//Создание залитого круга с радиусом и центром X, Y
            b.Dispose();//Сборщик мусора, удаление кисти из памяти
        }
    }
    public class ParticleColorful : Particle
    {

        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
                );
        }
        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);
            var color = MixColor(color1, color2, k);
            var b = new SolidBrush(color);
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
    }
}

