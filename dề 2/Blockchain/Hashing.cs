using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Blockchain
{
    public class Hashing
    {
        public static byte[] ComputeHashSha256(byte[] toBeHash)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHash);
            }
        }
        public static byte[] ComputeHashSha384(byte [] toBeHash)
        {
            using (var sha384 = SHA384.Create())
            {
                return sha384.ComputeHash(toBeHash);
            }
        }
        public static byte[] ComputeHashSha512(byte[] toBeHash)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHash);
            }
        }
    }
}
