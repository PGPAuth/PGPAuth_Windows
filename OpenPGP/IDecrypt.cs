using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Interface for algorithms supporting the decryption of things.
    /// </summary>
    public interface IDecrypt
    {
        /// <summary>
        /// Decrypt the given data with the given key.
        /// </summary>
        /// <param name="data">Data to be decrypted.</param>
        /// <param name="key">Key to be used to decrypt the data.</param>
        /// <returns>Decrypted data.</returns>
        byte[] decryptData(byte[] data, Key key);
    }
}
