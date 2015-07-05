using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Base-class for supported algorithms.
    /// </summary>
    public abstract class AlgorithmBase
    {
        /// <summary>
        /// The algorithm implemented by this class.
        /// </summary>
        public abstract KeyAlgorithm Algorithm
        {
            get;
        }
    }
}
