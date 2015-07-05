using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Interface for algorithms supporting the generation of digital signatures.
    /// </summary>
    public interface ISign
    {
        /// <summary>
        /// Sign the given data.
        /// </summary>
        /// <param name="data">The data to be signed.</param>
        /// <param name="key">The to be used to issue the signature.</param>
        /// <returns>The signature in way defined by the algorithm.</returns>
        byte[] signData(byte[] data, Key key);
    }
}
