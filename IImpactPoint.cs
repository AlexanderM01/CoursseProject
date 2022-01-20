using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public List<Particle> particles = new List<Particle>();

        // абстрактный метод с помощью которого изменяутся состояние частиц
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.Red),
                X - 5,
                Y - 5,
                10,
                10
            );
        }
    }

    public class GravityPoint : IImpactPoint//круг притяжения
    {
        public int Power = 100;// сила притяжения
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }
        public override void Render(Graphics g)
        {
            //рисуем окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
            );
        }
    }

    public class AntiGravityPoint : IImpactPoint //круг отталкивания
    {
        public int Power = 100;// сила притяжения
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }
    }

    public class Cyrcle : IImpactPoint
    {
        public List<Particle> par = new List<Particle>();
        public Color col = Color.Green;
        public int Raduis = 30;
        public int count = 0;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r2 = Math.Sqrt(gX * gX + gY * gY);
            if (r2 - particle.Radius <= Raduis)
            {
                particle.color1 = col;
                particle.color2 = col;
                par.Add(particle);
                count = par.Count;
            }
            else if (r2 - particle.Radius > Raduis)
            {
                particle.color1 = particle.FromColor;
                particle.color2 = particle.ToColor;
            }
            if (par.Count == 0)
            {
                count = 0;
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(new SolidBrush(col), 2), X - Raduis, Y - Raduis, Raduis * 2, Raduis * 2);
            g.DrawString(
                $"{count}",
                new Font("Colibri", 10),
                new SolidBrush(Color.Red),
                X,
                Y
            );
        }
    }

    public class Schetchik : IImpactPoint
    {
        public int schet = 0;
        public float radius = 10;
        public Color color;

        public override void ImpactParticle(Particle particle)
        {

            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r - particle.Radius < radius)
            {
                particle.Life = 0;
                schet++;
            }
        }
        public override void Render(Graphics g)
        {
            if (schet <= 5000) color = Color.FromArgb(205, 92, 92);
            else if (schet > 5001 && schet <= 10000) color = Color.FromArgb(255, 160, 122);
            else if (schet > 10001 && schet <= 15000) color = Color.FromArgb(220, 20, 60);
            else if (schet > 15001 && schet <= 20000) color = Color.FromArgb(255, 0, 0);
            else if (schet > 20001 && schet <= 25000) color = Color.FromArgb(255, 20, 147);
            else if (schet > 25001 && schet <= 30000) color = Color.FromArgb(255, 182, 193);
            else if (schet > 30001 && schet <= 35000) color = Color.FromArgb(255, 215, 0);
            else if (schet > 35001 && schet <= 40000) color = Color.FromArgb(255, 0, 255);
            else if (schet > 40001 && schet <= 45000) color = Color.FromArgb(139, 0, 139);
            else if (schet > 45001 && schet <= 50000) color = Color.FromArgb(106, 90, 205);
            else if (schet > 50001 && schet <= 55000) color = Color.FromArgb(173, 255, 47);
            else if (schet > 55001 && schet <= 60000) color = Color.FromArgb(0, 250, 154);
            else if (schet > 60001 && schet <= 65000) color = Color.FromArgb(0, 0, 255);
            else if (schet > 65001 && schet <= 70000) color = Color.FromArgb(119, 136, 153);
            else if (schet > 70001 && schet <= 75000) color = Color.FromArgb(47, 79, 79);
            else if (schet > 75001 && schet <= 80000) color = Color.FromArgb(220, 220, 220);
            else if (schet > 80001 && schet <= 85000) color = Color.FromArgb(123, 104, 238);
            else color = Color.Aquamarine;
            g.DrawEllipse(
                new Pen(
                    new SolidBrush(color), 5),
                    X - radius,
                    Y - radius,
                    radius * 2,
                    radius * 2
            );
            var str = new StringFormat();
            str.Alignment = StringAlignment.Center;
            str.LineAlignment = StringAlignment.Center;

            g.DrawString(
                $"{schet}",
                new Font("Colibri", 10),
                new SolidBrush(color),
                X,
                Y
            );
        }
    }
}
