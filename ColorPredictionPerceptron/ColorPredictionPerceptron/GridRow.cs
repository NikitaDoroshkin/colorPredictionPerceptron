using System;

namespace ColorPredictionPerceptron
{
    public class GridRow
    {
        public String weightR { get; set; }
        public String weightG { get; set; }
        public String weightB { get; set; }
        public String color { get; set; }
        public String result { get; set; }

        public GridRow(double weightR, double weightG, double weightB, double result, TargetColor color)
        {
            this.weightR = String.Format("{0:0.000}", weightR);
            this.weightG = String.Format("{0:0.000}", weightG);
            this.weightB = String.Format("{0:0.000}", weightB);
            this.color = color.ToString();
            this.result = String.Format("{0:0.000}", result);
        }
    }
}
