using System;
using static System.Math;

namespace ПИ32_Гусев_NUM4.NeuroNet
{
    class Neuron
    {
        private NeuronType type;
        private double[] weights;
        private double[] inputs;

        private double output;
        private double derivative;

        // private double a = 0.01d;

        public double[] Weights { get =>  weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }

        public Neuron(double[] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        public void Activator(double[] i)
        {
            inputs = i; // передача вектора входного сигнала в массив входных данных нейрона

            double sum = weights[0];

            // Цикл вычисления индуцированного поля нейрона (линейные преобразования входных сигналов)
            for (int j = 0; j < inputs.Length; j++)
            {
                sum += inputs[j] * weights[j + 1];
            }
            output = Logistic(sum);
            derivative = output * (1.0 - output);
        }

        // Логистическая функция активации
        private double Logistic(double sum)
        {
            // Ограничиваем sum
            if (sum < -45.0) return 0.0;
            if (sum > 45.0) return 1.0;

            return 1.0 / (1.0 + Math.Exp(-sum));
        }
    }
}
