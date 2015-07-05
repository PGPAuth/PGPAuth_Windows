using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Interface for algorithms supporting the encryption of things.
    /// </summary>
    public interface IEncrypt
    {
        /// <summary>
        /// Encrypt the given data with the given key.
        /// </summary>
        /// <param name="data">Data to be encrypted.</param>
        /// <param name="key">Key to encrypt the data.</param>
        /// <returns>Encrypted data.</returns>
        byte[] encryptData(byte[] data, Key key);
    }
}
