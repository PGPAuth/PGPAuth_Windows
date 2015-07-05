using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// RSAPrivateKey using BouncyCastle for all the crypto.
    /// </summary>
    public sealed class RSAPrivateKey : PrivateKey
    {
        /// <summary>
        /// The actual private key to be used with BouncyCastle.
        /// </summary>
        private RsaPrivateCrtKeyParameters _bcKey;

        /// <summary>
        /// Creates a new instance of the RSAPrivateKey-class.
        /// </summary>
        /// <param name="param">The private component of the AsymmetricKeyPair given by BouncyCastle.</param>
        public RSAPrivateKey(AsymmetricKeyParameter param)
        {
            _bcKey = (RsaPrivateCrtKeyParameters)param;
        }

        /// <summary>
        /// The algorithm the key is intended for.
        /// </summary>
        public override KeyAlgorithm Algorithm
        {
            get { return KeyAlgorithm.RSA; }
        }

        /// <summary>
        /// Length of the Key in bits.
        /// </summary>
        public override short Length
        {
            get { return (short)_bcKey.Modulus.BitLength; }
        }

        /// <summary>
        /// The BouncyCastle-key used for the actual crypto.
        /// </summary>
        public RsaPrivateCrtKeyParameters BCKey
        {
            get
            {
                return _bcKey;
            }
        }
    }
}
