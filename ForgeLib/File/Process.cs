namespace ForgeLib.File
{
    public static class Process
    {
        internal static void Write(byte[] data, string path)
        {
            System.IO.File.WriteAllBytes(path, data);
        }

        public static byte[] Read(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        internal static byte[] Encode(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        public static string Decode(byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
