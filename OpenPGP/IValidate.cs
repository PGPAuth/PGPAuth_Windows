using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Interface for algorithms supporting the validation of digital signatures.
    /// </summary>
    public interface IValidate
    {
        /// <summary>
        /// Validate the digital signature against the given key.
        /// </summary>
        /// <param name="data">Data which has been signed.</param>
        /// <param name="signature">Signature over the data.</param>
        /// <param name="key">Key to check the signature against</param>
        /// <returns>true for a valid signature, false otherwise.</returns>
        bool validateData(byte[] data, byte[] signature, Key key);
    }
}
