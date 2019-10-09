using System;

namespace ColorPredictionPerceptron
{
    class RgbColor
    {
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public RgbColor(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
}
