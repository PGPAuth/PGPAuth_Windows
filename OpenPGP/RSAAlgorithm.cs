using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Implementation of RSA using BouncyCastle for the Crypto.
    /// </summary>
    public sealed class RSAAlgorithm : AlgorithmBase, ISign, IValidate, IEncrypt, IDecrypt, IGenerate
    {
        /// <summary>
        /// Sign the given data with the given key.
        /// </summary>
        /// <param name="data">Data to be signed.</param>
        /// <param name="key">Key to be used for the signature. Must be RSAPrivateKey.</param>
        /// <returns>Digital signature.</returns>
        public byte[] signData(byte[] data, Key key)
        {
            Debug.Assert(key is RSAPrivateKey, "You need an RSAPrivateKey to sign messages using RSA.");
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validate the digital signature against the given key.
        /// </summary>
        /// <param name="data">Data which has been signed.</param>
        /// <param name="signature">Signature over the data.</param>
        /// <param name="key">Key to check the signature against. Must be an instance of RSAPublicKey.</param>
        /// <returns>true for a valid signature, false otherwise.</returns>
        public bool validateData(byte[] data, byte[] signature, Key key)
        {
            Debug.Assert(key is RSAPublicKey, "You need an RSAPublicKey to validate RSA signatures.");
            throw new NotImplementedException();
        }

        /// <summary>
        /// Encrypt the given data with the given key.
        /// </summary>
        /// <param name="data">Data to be encrypted.</param>
        /// <param name="key">Key to encrypt the data. Must be the RSAPublicKey of the recipient.</param>
        /// <returns>Encrypted data.</returns>
        public byte[] encryptData(byte[] data, Key key)
        {
            Debug.Assert(key is RSAPublicKey, "You need an RSAPublicKey to encrypt messages with RSA.");
            throw new NotImplementedException();
        }

        /// <summary>
        /// Decrypt the given data with the given key.
        /// </summary>
        /// <param name="data">Data to be decrypted.</param>
        /// <param name="key">Key to be used to decrypt the data. Must be the RSAPrivateKey the message was encrypted for.</param>
        /// <returns>Decrypted data.</returns>
        public byte[] decryptData(byte[] data, Key key)
        {
            Debug.Assert(key is RSAPrivateKey, "You need an RSAPrivateKey to decrypt messages with RSA.");
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generate a new key with the given length.
        /// </summary>
        /// <param name="length">Length of the key to be generated. Usually given in bits, but depends on the algorithm.</param>
        /// <returns>New RSAPrivateKey with the PublicKey-property set to the corresponding RSAPublicKey.</returns>
        public Key generateKey(short length)
        {
            Debug.Assert(length >= 2048, "The key must be at least 2048 bits in length.");
            Debug.Assert(((length % 1024) == 0), "The key must be a power of 1024.");

            RsaKeyPairGenerator generator = new RsaKeyPairGenerator();
            generator.Init(new KeyGenerationParameters(new SecureRandom(), length));
            AsymmetricCipherKeyPair pair = generator.GenerateKeyPair();

            RSAPrivateKey privateKey = new RSAPrivateKey(pair.Private);
            RSAPublicKey publicKey = new RSAPublicKey(pair.Public);

            privateKey.PublicKey = publicKey;

            return privateKey;
        }

        /// <summary>
        /// The algorithm implemented by this class.
        /// </summary>
        override public KeyAlgorithm Algorithm
        {
            get { return KeyAlgorithm.RSA; }
        }
    }
}
