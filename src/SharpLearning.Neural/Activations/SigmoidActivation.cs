using System;

namespace SharpLearning.Neural.Activations
{
    [Serializable]
    public sealed class SigmoidActivation : IActivation
    {
        public void Activation(float[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Sigmoid(x[i]);
            }
        }

        public void Derivative(float[] x, float[] output)
        {
            for (int i = 0; i < x.Length; i++)
            {
                output[i] = Derivative(x[i]);
            }
        }

        private static float Sigmoid(float x)
        {
            return (float) (1f / (1 + Math.Exp(-x)));
        }

        private static float Derivative(float x)
        {
            return x * (1 - x);
        }
    }
}