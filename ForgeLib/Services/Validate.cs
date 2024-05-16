using ForgeLib.File;

namespace ForgeLib.Services
{
    public static class Validate
    {
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

        public static bool FileExists(string path)
        {
            return System.IO.File.Exists(path);
        }

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
