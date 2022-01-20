using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
   public class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;

        public void UpdateState()
        {

            foreach (var particle in particles)
            {
                particle.Life -= 1;  // не трогаем
                if (particle.Life < 0)
                {
                    // тоже не трогаем
                    particle.Life = 20 + Particle.rand.Next(100);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;

                    /* ЭТО ДОБАВЛЯЮ, тут сброс состояния частицы */
                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
                    /* конец ЭТО ДОБАВЛЯЮ  */

                    // это не трогаем
                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    // и добавляем новый, собственно он даже проще становится, 
                    // так как теперь мы храним вектор скорости в явном виде и его не надо пересчитывать
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
                {
                    // а у тут уже наш новый класс используем
                    var particle = new ParticleColorful();
                    // ну и цвета меняем
                    particle.FromColor = Color.Yellow;
                    particle.ToColor = Color.FromArgb(0, Color.Magenta);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        public void Render(Graphics g)
        {
            
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}
