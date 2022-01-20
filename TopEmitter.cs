using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class TopEmitter : Emitter
    {
        public int Width;//длина экрана

        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle);//базовый сброс частицы

            //Параметры движения
            particle.X = Particle.rand.Next(Width);
            particle.Y = 0;//Вверх экрана

            particle.SpeedY = 1;//падаем вниз
            particle.SpeedX = Particle.rand.Next(-2, 2);//разброс влево и вправа у частиц
        }
    }
}