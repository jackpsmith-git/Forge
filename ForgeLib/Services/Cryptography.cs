using System.Security.Cryptography;
using System.Text;
using ForgeLib.File;
using static BCrypt.Net.BCrypt;

namespace ForgeLib.Services
{
    public static class Cryptography
    {
        internal static string Hash(string exposedString)
        {
            int intWorkFactor = 15;
            string strHash = EnhancedHashPassword(exposedString, intWorkFactor, BCrypt.Net.HashType.SHA512);
            return strHash;
        }

        public static bool VerifyHash(string keyPath, string hashPath)
        {
            return EnhancedVerify(Process.Decode(Process.Read(keyPath)), Process.Decode(Process.Read(hashPath)), BCrypt.Net.HashType.SHA512);
        }

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

        private static void SaveKey(byte[] key, string id)
        {
            string path = File.Directory.GetDecryptionKeyPath(id);
            Process.Write(key, path);
            File.Directory.SetReadOnly(path);
        }

        private static void SaveIV(byte[] iv, string id)
        {
            string path = File.Directory.GetIVPath(id);
            Process.Write(iv, path);
            File.Directory.SetReadOnly(path);
        }
    }
}
