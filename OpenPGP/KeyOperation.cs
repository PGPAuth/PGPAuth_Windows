using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPGP
{
    /// <summary>
    /// All the operations.
    /// </summary>
    [Flags()]
    public enum KeyOperation
    {
        Sign = 1,
        Validate = 2,
        Encrypt = 4,
        Decrypt = 8,
        Generate = 16,
    }
}
