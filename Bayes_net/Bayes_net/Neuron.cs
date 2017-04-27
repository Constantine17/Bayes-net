using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayes_net
{
    class Neuron
    {
        public double weight {get;set;}

        public Neuron()
        {
            weight = 0.5;
        }

        public Neuron(double weig)
        {
            weight = weig;
        }

        public void Signal(byte input)
        {
            
        }

        public string Output()
        { return Convert.ToString(weight); }

    }

    class wNeuron : Neuron
    {
        public double ADD {get;set;}
        public wNeuron(Neuron[,] ner)
        {
            int k = ner.Length;
            ADD = 0;
            for (int i = 0; i < 30; i++) // <WARRNING>  !!!!!!!!!!!!!
                for (int j = 0; j < 30; j++)// <WARRNING>  !!!!!!!!!!!!!
                    ADD += ner[i, j].weight;
           
        }
        public string Output()
        { return Convert.ToString(ADD); }
    }
}
