using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Class to instantiate algorithm-classes.
    /// </summary>
    public sealed class Factory
    {
        /// <summary>
        /// Creates a new instance of a specified algorithm-class.
        /// </summary>
        /// <param name="algorithm">The algorithm to use.</param>
        /// <param name="operation">The operations required to be supported.</param>
        /// <returns>Instance of the right algorithm class guaranted to support the given operations (i.e. implementing the correct interfaces).</returns>
        public static AlgorithmBase Create(KeyAlgorithm algorithm, KeyOperation operation)
        {
            Type type = Type.GetType("OpenPGP." + algorithm.ToString() + "Algorithm");
            AlgorithmBase instance = (AlgorithmBase)Activator.CreateInstance(type);

            return instance;
        }

        /// <summary>
        /// Creates a new instance of a specified algorithm-class.
        /// </summary>
        /// <param name="algorithm">The algorithm to use.</param>
        /// <param name="operation">The operations required to be supported.</param>
        /// <typeparam name="T">The type the instance shall be casted to (can be any AlgorithmBase or any of the interfaces).</typeparam>
        /// <returns>Instance of the right algorithm class guaranted to support the given operations (i.e. implementing the correct interfaces).</returns>
        public static T Create<T>(KeyAlgorithm algorithm, KeyOperation operation) where T : AlgorithmBase, ISign, IValidate, IEncrypt, IDecrypt, IGenerate
        {
            return Create(algorithm, operation) as T;
        }
    }
}
