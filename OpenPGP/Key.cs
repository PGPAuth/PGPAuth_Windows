using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Base class for keys.
    /// </summary>
    public abstract class Key
    {
        /// <summary>
        /// Algorithm this key is intended for.
        /// </summary>
        public abstract KeyAlgorithm Algorithm
        {
            get;
        }

        /// <summary>
        /// Length of the key in bits.
        /// </summary>
        public abstract short Length
        {
            get;
        }
    }
}
