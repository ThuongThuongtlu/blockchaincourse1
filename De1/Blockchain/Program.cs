using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Moi nhap chuoi 1 : ");
            a = Console.ReadLine();
            Console.WriteLine("Moi nhap chuoi 2 : ");
            b = Console.ReadLine();
            SHA256(a, b);
            SHA384(a, b);
            SHA512(a, b);
        }
        public static void SHA256(string originalMessage, string originalMessage2)
        {
            Console.WriteLine("Message 1 : " + originalMessage);
            Console.WriteLine("Message 2 : " + originalMessage2);
            var sha256HashedMessage = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage));
            var sha256HashedMessage2 = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage2));
            Console.WriteLine("SHA256 Hashes");
            Console.WriteLine("");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha256HashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha256HashedMessage2));
            Console.WriteLine();
        }
        private static void SHA384(string originalMessage, string originalMessage2)
        {
            Console.WriteLine("Message 1 : " + originalMessage);
            Console.WriteLine("Message 2 : " + originalMessage2);
            var sha384HashedMessage = Hashing.ComputeHashSha384(Encoding.UTF8.GetBytes(originalMessage));
            var sha384HashedMessage2 = Hashing.ComputeHashSha384(Encoding.UTF8.GetBytes(originalMessage2));
            Console.WriteLine("SHA384 Hashes");
            Console.WriteLine("");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha384HashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha384HashedMessage2));
            Console.WriteLine();
        }
        private static void SHA512(string originalMessage, string originalMessage2)
        {
            Console.WriteLine("Message 1 : " + originalMessage);
            Console.WriteLine("Message 2 : " + originalMessage2);
            var sha512HashedMessage = Hashing.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage));
            var sha512HashedMessage2 = Hashing.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage2));
            Console.WriteLine("SHA512 Hashes");
            Console.WriteLine("");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha512HashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha512HashedMessage2));
            Console.WriteLine();
        }
    }
}
