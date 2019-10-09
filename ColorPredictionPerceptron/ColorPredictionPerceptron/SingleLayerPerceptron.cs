using System;

namespace ColorPredictionPerceptron
{
    class SingleLayerPerceptron
    {
        private static Random trueColorRandom = new Random();

        public const int neuronCount = 8;
        public Neuron[] neurons = new Neuron[neuronCount];

        public SingleLayerPerceptron()
        {
            for (int i = 0; i < neuronCount; i++)
            {
                neurons[i] = new Neuron();
            }
        }


        double ActiveSigm(double x)
        {
            return 1 / (1 + Math.Pow(Math.E, -x)) - 0.5;
        }

        double ActiveSigmDeriv(double x)
        {
            return Math.Pow(Math.E, -x) / Math.Pow(1 + Math.Pow(Math.E, -x), 2);
        }

        private void ProcessNetwork()
        {
            double sum;
            for (int i = 0; i < neuronCount; i++)
            {
                sum = 0;
                for (int j = 0; j < Neuron.INPUTS_COUNT; j++)
                {
                    sum += neurons[i].x[j] * neurons[i].w[j];
                }
                neurons[i].sum = sum;
                neurons[i].y = ActiveSigm(sum);
            }
        }

        public double[] GetNetworkResult(double[] inputSignals)
        {
            SetNeuronInputs(inputSignals);
            ProcessNetwork();
            double[] outputs = new double[neuronCount];
            for (int i = 0; i < neuronCount; i++)
            {
                outputs[i] = neurons[i].y;
            }
            return outputs;
        }

        public void Teach(int index)
        {
            ProcessNetwork();
            double real;
            for (int i = 0; i < neuronCount; i++)
            {
                real = 0;
                if (index == i)
                {
                    real = 1;
                }
                double deltaRes = neurons[i].y - real;
                double delta = ActiveSigmDeriv(neurons[i].sum) * deltaRes;
                for (int j = 0; j < Neuron.INPUTS_COUNT; j++)
                {
                    neurons[i].w[j] -= neurons[i].x[j] * delta;
                }
            }
        }

        public void SetNeuronInputs(double[] inputSignals)
        {
            for (int i = 0; i < neuronCount; i++)
                neurons[i].x = inputSignals;
        }

        public void Teach()
        {
            double r;
            double g;
            double b;
            int trueColor;
            for (int i = 0; i < 1000; i++)
            {
                r = trueColorRandom.NextDouble();
                g = trueColorRandom.NextDouble();
                b = trueColorRandom.NextDouble();
                SetNeuronInputs(new double[] { r, g, b });
                trueColor = (int)ColorFunction.CalculateColor(r, g, b);
                Teach(trueColor);
            }
        }

    }
}
