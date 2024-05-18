namespace ForgeLib.File
{
    /// <summary>
    /// Static class containing Forge directory properties and methods
    /// </summary>
    public static class Directory
    {

        /// <summary>
        /// The startup directory of the application.
        /// </summary>
        public static string STARTUP = AppContext.BaseDirectory;

        /// <summary>
        /// The temp directory of the application.
        /// </summary>
        public static string TEMP = AppContext.BaseDirectory + @"\temp";

        /// <summary>
        /// The exports directory of the application.
        /// </summary>
        public static string EXPORTS = AppContext.BaseDirectory + @"\temp\exports";

        /// <summary>
        /// The vaults directory of the application.
        /// </summary>
        public static string VAULTS = AppContext.BaseDirectory + @"\dmF1bHRz";

        /// <summary>
        /// Initializes the directories that the application requires to perform operations.
        /// </summary>
        /// <returns>void</returns>
        internal static void InitializeAll()
        {
            System.IO.Directory.CreateDirectory(STARTUP);
            System.IO.Directory.CreateDirectory(TEMP);
            System.IO.Directory.CreateDirectory(EXPORTS);

            System.IO.Directory.CreateDirectory(VAULTS);
            Hide(VAULTS);
            Clear(EXPORTS);
        }

        /// <summary>
        /// Deletes all files in the given directory.
        /// </summary>
        /// <param name="path">The path of the directory to clear.</param>
        /// <returns>void</returns>
        public static void Clear(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        /// <summary>
        /// Hides a given directory.
        /// </summary>
        /// <param name="path">The directory to hide.</param>
        /// <returns>void</returns>
        public static void Hide(string path)
        {
            DirectoryInfo di = new(path);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        }

        /// <summary>
        /// <para>Merges the given directory, file name, and extension into one string.</para>
        /// <para>Directory must not end with a backslash.</para> 
        /// <para>Extension must include a period.</para>
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="name"></param>
        /// <param name="extension"></param>
        /// <returns>Merged file path.</returns>
        public static string FormPath(string dir, string name, string extension)
        {
            string[] strings = [dir, @"\", name];
            return Path.Join(strings) + extension;
        }

        /// <summary>
        /// Determines the file path of the encryption key based on the vault id.
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <returns>Decryption key path</returns>
        public static string GetDecryptionKeyPath(string id)
        {
            return FormPath(VAULTS + @"\" + id, id + "_fdk", ".fdk");
        }

        /// <summary>
        /// Determines the file path of the hash based on the vault id.
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <returns>Hash path</returns>
        public static string GetHashPath(string id)
        {
            return FormPath(VAULTS + @"\" + id, id + "_fvh", ".fvh");
        }

        /// <summary>
        /// Determines the file path of the vault based on the vault id.
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <returns>Vault path</returns>
        public static string GetVaultPath(string id)
        {
            return FormPath(VAULTS + @"\" + id, id + "_fve", ".fve");
        }

        /// <summary>
        /// Determines the file path of the initialization vector based on the vault id.
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <returns>IV path</returns>
        public static string GetIVPath(string id)
        {
            return FormPath(VAULTS + @"\" + id, id + "_fiv", ".fiv");
        }

    }
}
