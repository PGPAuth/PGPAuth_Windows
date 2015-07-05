using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Interface for algorithms supporting the generation of keys.
    /// </summary>
    public interface IGenerate
    {
        /// <summary>
        /// Generate a new key with the given length.
        /// </summary>
        /// <param name="length">Length of the key to be generated. Usually given in bits, but depends on the algorithm.</param>
        /// <returns>New Key usable for all the cool stuff.</returns>
        Key generateKey(short length);
    }
}
