﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
   public class Emitter
    {
        public float GravitationX = 0;
        public float GravitationY = 0; 
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    ResetParticle(particle); // заменили этот блок на вызов сброса частицы 
                }
                else                
                    {
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    // это не трогаем
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < ParticlesCount)
                {
                    /* ну и тут чуток подкрутили */
                    var particle = new ParticleColorful();
                    particle.FromColor = Color.White;
                    particle.ToColor = Color.FromArgb(0, Color.Black);

                    ResetParticle(particle); // добавили вызов ResetParticle

                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }
        public int ParticlesCount = 500;
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.rand.Next(100);
            particle.X = MousePositionX;
            particle.Y = MousePositionY;

            var direction = (double)Particle.rand.Next(360);
            var speed = 1 + Particle.rand.Next(10);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.rand.Next(10);
        }

        public void Render(Graphics g)
        {
            // это не трогаем
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            // рисую точки притяжения красными кружочками
            foreach (var point in impactPoints) 
            {
                
                point.Render(g); // это добавили
            }
        }
    }
}
