﻿using System;
using System.Drawing;

namespace TagsCloudVisualization
{
    public class ArchimedeanSpiral
    {
        private readonly double a;
        private readonly double b;
        private readonly double angleStep;
        private readonly Point center;
        private double phi;
        private double Radius => a + b * phi;

        public ArchimedeanSpiral(Point center, double angleStep = Math.PI / 180, double a = 0, double b = 0.5)
        {
            phi = -angleStep;
            this.center = center;
            this.angleStep = angleStep;
            this.a = a;
            this.b = b;
        }

        public Point GetNextPoint()
        {
            phi += angleStep;
            return new Point(
                center.X + (int) Math.Round(Radius * Math.Cos(phi)),
                center.Y + (int) Math.Round(Radius * Math.Sin(phi)));
        }
    }
}