using System.Security.Cryptography;
using System.Text;
using ForgeLib.File;
using static BCrypt.Net.BCrypt;

namespace ForgeLib.Services
{
    /// <summary>
    /// Static class containing Forge cryptography methods
    /// </summary>
    public static class Cryptography
    {
        /// <summary>
        /// Generates a hash for a given string with BCrypt and SHA512.
        /// </summary>
        /// <param name="exposedString">The string to hash</param>
        /// <returns>Hashed string</returns>
        internal static string Hash(string exposedString)
        {
            int intWorkFactor = 10;
            string strHash = EnhancedHashPassword(exposedString, intWorkFactor, BCrypt.Net.HashType.SHA512);
            return strHash;
        }

        /// <summary>
        /// Verifies that the hash of the data in the given key path matches the stored hash.
        /// </summary>
        /// <param name="keyPath">Key path to read data from</param>
        /// <param name="hashPath">File path of the stored hash</param>
        /// <returns>true if the passwords match, otherwise false</returns>
        public static bool VerifyHash(string keyPath, string hashPath)
        {
            return EnhancedVerify(Process.Decode(Process.Read(keyPath)), Process.Decode(Process.Read(hashPath)), BCrypt.Net.HashType.SHA512);
        }

        /// <summary>
        /// Encrypts a string into a byte array containing the encrypted data using AES.
        /// </summary>
        /// <param name="plaintext">String to encrypt</param>
        /// <param name="id">Vault ID</param>
        /// <returns>Encrypted data</returns>
        public static byte[] Encrypt(string plaintext, string id)
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                SaveKey(aes.Key, id);
                SaveIV(aes.IV, id);
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encryptedBytes;
                using (MemoryStream msEncrypt = new())
                {
                    using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Process.Encode(plaintext);
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
                return encryptedBytes;
            }
        }

        /// <summary>
        /// Decrypts a byte array into a string using AES.
        /// </summary>
        /// <param name="ciphertext">Encrypted data</param>
        /// <param name="key">Decryption key</param>
        /// <param name="iv">Initialization vector</param>
        /// <returns>Decrypted string</returns>
        public static string Decrypt(byte[] ciphertext, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] decryptedBytes;
                using (MemoryStream msDecrypt = new(ciphertext))
                {
                    using (CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msPlain = new())
                        {
                            csDecrypt.CopyTo(msPlain);
                            decryptedBytes = msPlain.ToArray();
                        }
                    }
                }
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        /// <summary>
        /// Saves a decryption key to a file path within the vault corresponding to the given vault ID.
        /// </summary>
        /// <param name="key">Decryption key</param>
        /// <param name="id">Vault ID</param>
        /// <returns>void</returns>
        private static void SaveKey(byte[] key, string id)
        {
            string path = File.Directory.GetDecryptionKeyPath(id);
            Process.Write(key, path);
        }

        /// <summary>
        /// Saves an initialization vector to a file path within the vault corresponding to the given vault ID.
        /// </summary>
        /// <param name="iv">Initialization vector</param>
        /// <param name="id">Vault ID</param>
        /// <returns>void</returns>
        private static void SaveIV(byte[] iv, string id)
        {
            string path = File.Directory.GetIVPath(id);
            Process.Write(iv, path);
        }
    }
}
