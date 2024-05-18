using ForgeLib.File;

namespace ForgeLib.Services
{
    /// <summary>
    /// Static class for validating data entered by the user into the Forge application
    /// </summary>
    public static class Validate
    {
        /// <summary>
        /// Validates an entered new vault ID
        /// </summary>
        /// <param name="id">New Vault ID</param>
        /// <returns>true if valid, otherwise false</returns>
        public static bool NewVaultID(string id)
        {
            if (IsEmpty(id))
            {
                return false;
            }

            foreach (char character in Path.GetInvalidFileNameChars())
            {
                if (id.Contains(character))
                {
                    return false;
                }
            }

            if (id.Contains(' '))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates an entered vault Key
        /// </summary>
        /// <param name="id">Vault ID</param>
        /// <param name="dirText">Directory of the key path</param>
        /// <returns>true if valid, otherwise false</returns>
        public static bool VaultKey(string id, string dirText)
        {
            if (Process.Read(File.Directory.GetHashPath(id)) == null)
            {
                return false;
            }

            if (Process.Decode(Process.Read(dirText)) == string.Empty)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates if a file exists in the given path
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>true if a file exists in the given path, otherwise false</returns>
        public static bool FileExists(string path)
        {
            return System.IO.File.Exists(path);
        }

        /// <summary>
        /// Validates if a string is empty.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>True if empty, otherwise false</returns>
        public static bool IsEmpty(string str)
        {
            if (str == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
