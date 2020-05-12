using System;

namespace ConsoleApp1.practical.geometryExample
{
    public class process
    {
        private double radius;
        private double height;

        public process()
        {
        }

        public process(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }


        public double getBaseArea()
        {
            double BaseArea;
            BaseArea = Radius * Radius * Math.PI;
            return BaseArea;
        }

        public double getLateralArea()
        {
            double LateralArea;
            LateralArea = 2 * Math.PI * Radius * Height;
            return LateralArea;
        }

        public double getTotalArea()
        {
            double TotalArea;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            return TotalArea;
        }

        public double getVolume()
        {
            double Volume;
            Volume = Math.PI * Radius * Radius * Height;
            return Volume;
        }

    }
}