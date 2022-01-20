using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Emitter
    {
        List<Particle> particles = new List<Particle>();//Список частиц
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();//Точки притяжения
        public int MousePositionX = 0;//Положение мыши по X
        public int MousePositionY = 0;//Положение мыши по Y
        public float GravitationX = 0;
        public float GravitationY = 1;
        public int ParticlesCount = 500;//кол-во частиц

        public int X;//координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y;//координата Y 
        public int Direction = 0;// вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360;//разброс частиц относительно Direction
        public int SpeedMin = 1;// начальная минимальная скорость движения частицы
        public int SpeedMax = 10; //начальная максимальная скорость движения частицы
        public int RadiusMin = 2; //минимальный радиус
        public int RadiusMax = 10; //максимальный радиус
        public int LifeMin = 20; //минимальное время жизни
        public int LifeMax = 100; //максимальное время жизни

        public int ParticlesPerTick = 1;

        public Color ColorFrom = Color.White;//начальный цвет частиц
        public Color ColorTo = Color.FromArgb(0, Color.Black);//конечный цвет частиц

        Cyrcle cyrcle = new Cyrcle();

        public void UpdateState() //Обновление логики
        {
            //cyrcle.par.Clear();
            int particlesToCreate = ParticlesPerTick;//счётчик частиц за тик
            foreach (var particle in particles) //пересчитывание положения частиц в соответствии с их направлением движения и скоростью.
            {
                if (particle.Life <= 0)
                {
                    if (particlesToCreate > 0)
                    {
                        //сброс частиц = создание частиц
                        particlesToCreate -= 1; //уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                    particle.Life -= 1;//Уменьшение здоровья

                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    // гравитация воздействует на вектор скорости, поэтому пересчитываем его
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }
            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle); //Добавление списка
            }
        }

        public void Render(Graphics g) //Отрисовка
        {
            foreach (var particle in particles) //отрисовка частиц
            {
                if (particle.Life != 0)
                {
                    particle.Draw(g);
                }
            }
            foreach (var point in impactPoints)//Красный круг притяжения
            {
                point.Render(g);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);//Восстановление здоровья
            particle.X = X; //Перенос частиц 
            particle.Y = Y;

            particle.color1 = ColorFrom;
            particle.color2 = ColorTo;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = 1 + Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);//рандомный радиус
        }

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }
    }
}
