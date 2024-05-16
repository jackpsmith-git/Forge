using ForgeLib.Objects;
using ForgeLib.Services;
using System.Diagnostics;

namespace ForgeLib
{
    public static class App
    {
        /// <summary>
        /// The vault that the application is currently using.
        /// </summary>
        public static Vault? activeVault;

        /// <summary>
        /// The mutex used to identify if an instance of the app is already running.
        /// </summary>
        public readonly static string GUID = "FVM_dmF1bHRz";

        public static void Initialize()
        {
            File.Directory.InitializeAll();
        }

        /// <summary>
        /// Creates a new Key object.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="notes"></param>
        /// <returns>The created key.</returns>
        public static Key CreateKey(string service, string username, string password, string notes)
        {
            return new Key()
            { 
                service = service, 
                username = username, 
                password = password, 
                notes = notes 
            };
        }

        /// <summary>
        /// Creates a new vault object.
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <param name="directory">Directory to store vault key.</param>
        /// <returns>The created vault.</returns>
        public static Vault CreateVault(string id, string directory)
        {
            Vault vault = new();

            string exposedVaultKey = Rng.GenerateRandomString(32);
            vault.hash = Cryptography.Hash(exposedVaultKey);
            vault.id = id;

            Directory.CreateDirectory(File.Directory.VAULTS + @"\" + id);
            SaveVaultKey(exposedVaultKey, directory, id);
            SaveVault(vault);
            return vault;
        }

        /// <summary>
        /// Converts the key to binary data and writes it to a file.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="dir">The directory to save the key to.</param>
        /// <param name="id">Vault ID.</param>
        public static void SaveVaultKey(string key, string dir, string id)
        {
            string path = dir + @"\" + id + "_fvk" + ".fvk";
            File.Process.Write(File.Process.Encode(key), path);
        }

        /// <summary>
        /// Serializes the vault to XML, then encrypts the data and writes it to the file path.
        /// </summary>
        /// <param name="vault"></param>
        /// <returns>void</returns>
        public static void SaveVault(Vault vault)
        {
            string path = File.Directory.GetVaultPath(vault.id);
            File.Process.Write(File.Process.Encode(vault.hash), File.Directory.GetHashPath(vault.id));
            File.Process.Write(Cryptography.Encrypt(Serialization.SerializeVault(vault), vault.id), path);
            return;
        }

        /// <summary>
        /// Reads the encrypted vault data from a file, then decryprs, and deserializes it into a new vault object.
        /// </summary>
        /// <param name="filePath">File path to read the vault data from.</param>
        /// <returns>Vault containing unencrypted data.</returns>
        public static Vault ReadVault(string filePath, string id)
        {
            string keyPath = File.Directory.GetDecryptionKeyPath(id);
            string ivPath = File.Directory.GetIVPath(id);
            byte[] key = File.Process.Read(keyPath);
            byte[] iv = File.Process.Read(ivPath);
            return Serialization.DeserializeVault(Cryptography.Decrypt(File.Process.Read(filePath), key, iv));
        }

        /// <summary>
        /// Reads the data in the file path, then decrypts it and deserializes it to a Vault object.
        /// </summary>
        /// <param name="filePath">The file path of the vault.</param>
        /// <returns>void</returns>
        public static void OpenVault(string filePath, string id)
        {
            Vault vault = ReadVault(filePath, id);            
            activeVault = vault;
        }

        /// <summary>
        /// Saves the given vault and sets the active vault in the application to null.
        /// </summary>
        /// <param name="vault">Vault to save.</param>
        /// <returns>void</returns>
        public static void LockVault(Vault vault)
        {
            SaveVault(vault);
            activeVault = null;
        }

        /// <summary>
        /// Locks the active vault if it is not null.
        /// </summary>
        /// <returns>void</returns>
        public static void Close()
        {
            if (activeVault != null)
            {
                LockVault(activeVault);
            }
        }

        /// <summary>
        /// Opens the repository help section in the README.md file.
        /// </summary>
        public static void ReportBug()
        {
            Process reportBug = new Process();
            reportBug.StartInfo.UseShellExecute = true;
            reportBug.StartInfo.FileName = "https://github.com/jackpsmith-git/ForgePasswordManagementUtility/blob/master/README.md#help";
            reportBug.Start();
        }
    }
}
