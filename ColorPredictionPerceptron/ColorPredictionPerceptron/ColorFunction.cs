namespace ColorPredictionPerceptron
{
    class ColorFunction
    {
        public static TargetColor CalculateColor(double red, double green, double blue)
        {
            double level = red;
            if (green > level)
                level = green;
            if (blue > level)
                level = blue;
            level = level * 0.7;
            int outColor = 0;
            if (red > level)
                outColor |= 1;
            if (green > level)
                outColor |= 2;
            if (blue > level)
                outColor |= 4;
            return (TargetColor)outColor;
        }
    }
}
