using System;

namespace ColorPredictionPerceptron
{
    class Neuron
    {
        private static Random randomWeightSource = new Random();

        public Neuron()
        {
            for (int j = 0; j < INPUTS_COUNT; j++)
            {
                x[j] = 0;
                w[j] = randomWeightSource.NextDouble();
            }
            y = 0;
            sum = 0;
        }

        public const int INPUTS_COUNT = 3;
        /**
         * входные сигналы
         * */
        public double[] x = new double[INPUTS_COUNT];
        /**
         * весовые коэффициенты
         * */
        public double[] w = new double[INPUTS_COUNT];
        /**
         * сумма
         * */
        public double sum;
        /**
         * выход аксон
         * */
        public double y;
    }
}
