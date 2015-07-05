using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenPGP;

namespace Tests
{
    /// <summary>
    /// This test is for all the crypto-functioniality.
    /// </summary>
    [TestClass]
    public class CryptoTests
    {
        /// <summary>
        /// Test if the Factory-class produces the right class-instances.
        /// </summary>
        [TestMethod]
        public void FactoryTest()
        {
            AlgorithmBase instance = Factory.Create(KeyAlgorithm.RSA, KeyOperation.Generate);

            Assert.IsInstanceOfType(instance, typeof(RSAAlgorithm));
            Assert.IsInstanceOfType(instance, typeof(IGenerate));
        }

        /// <summary>
        /// Test RSA key-generation.
        /// </summary>
        [TestMethod]
        public void RSAGenerateTest()
        {
            RSAAlgorithm instance = Factory.Create<RSAAlgorithm>(KeyAlgorithm.RSA, KeyOperation.Generate);

            const short KEY_LENGTH = 2048;
            Key privateKey = instance.generateKey(KEY_LENGTH);

            Assert.IsInstanceOfType(privateKey, typeof(RSAPrivateKey));
            Assert.AreEqual(privateKey.Length, KEY_LENGTH);
            Assert.IsInstanceOfType((privateKey as RSAPrivateKey).PublicKey, typeof(RSAPublicKey));
            Assert.AreEqual((privateKey as RSAPrivateKey).PublicKey.Length, KEY_LENGTH);
        }
    }
}
