using System;
using System.IO;
using System.Windows.Forms;

namespace ПИ32_Гусев_NUM4.NeuroNet
{
    abstract class Layer
    {
        protected string name_Layer;
        string pathDirWeights;
        string pathFileWeights;
        protected int numofneurons;
        protected int numofprevneurons;
        protected const double learningrate = 0.087d;
        protected const double momentum = 0.070d;
        protected double[,] lastdeltaweights;
        protected Neuron[] neurons;

        public double[] Data
        {
            set
            {
                for (int i = 0; i < numofneurons; i++)
                {
                    neurons[i].Activator(value);
                }
            }

        }

        protected Layer(int non, int nopn, NeuronType nt, string nm_Layer)
        {
            ;
        }
    }
}
