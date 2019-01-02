using System;

namespace SharpLearning.Neural.Activations
{
    public static class ActivationFactory
    {
        public static IActivation CreateActivation(Activation activation)
        {
            switch (activation)
            {
                case Activation.Relu:
                    return new ReluActivation();
                case Activation.Sigmoid:
                    return new SigmoidActivation();
                case Activation.Undefined:
                    throw new ArgumentException("ActivationLayer must have a defined activation function. Provided with: " + activation);
                default:
                    throw new ArgumentOutOfRangeException(nameof(activation), activation, null);
            }
        }
    }
}