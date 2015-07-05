using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// Private component of asymmtric keys.
    /// </summary>
    public abstract class PrivateKey : Key
    {
        /// <summary>
        /// Shortcut to the public key.
        /// Don't trust this one to be already set.
        /// </summary>
        public PublicKey PublicKey
        {
            get;
            set;
        }
    }
}
