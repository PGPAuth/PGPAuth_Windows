using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// The public component of an RSA-Key
    /// </summary>
    public sealed class RSAPublicKey : PublicKey
    {
        /// <summary>
        /// The RsaKeyParameters for BouncyCastle.
        /// </summary>
        private RsaKeyParameters _bcKey;

        /// <summary>
        /// Creates a new instance of the RSAPublicKey-class.
        /// </summary>
        /// <param name="param">Public component of AsymmetricKeyParameter from BouncyCastle</param>
        public RSAPublicKey(AsymmetricKeyParameter param)
        {
            _bcKey = (RsaKeyParameters)param;
        }

        /// <summary>
        /// The algorithm this key is intended for.
        /// </summary>
        public override KeyAlgorithm Algorithm
        {
            get { return KeyAlgorithm.RSA; }
        }

        /// <summary>
        /// The length of this key in bits.
        /// </summary>
        public override short Length
        {
            get
            {
                return (short)_bcKey.Modulus.BitLength;
            }
        }

        /// <summary>
        /// The BouncyCastle RsaKeyParameters.
        /// </summary>
        public RsaKeyParameters BCKey
        {
            get
            {
                return _bcKey;
            }
        }
    }
}
