namespace ForgeLib.File
{
    /// <summary>
    /// Static class containing Forge methods for processing file data
    /// </summary>
    public static class Process
    {
        /// <summary>
        /// Writes the data to the given file path.
        /// </summary>
        /// <param name="data">Data to write</param>
        /// <param name="path">File path</param>
        /// <returns>void</returns>
        internal static void Write(byte[] data, string path)
        {
            System.IO.File.WriteAllBytes(path, data);
        }

        /// <summary>
        /// Reads the data from the given file path.
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>Byte array containing data</returns>
        public static byte[] Read(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        /// <summary>
        /// Encodes the given string to a UTF8 byte array.
        /// </summary>
        /// <param name="str">Text to encode</param>
        /// <returns>Encoded byte array</returns>
        internal static byte[] Encode(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        /// <summary>
        /// Decodes the given UTF8 byte array into a string.
        /// </summary>
        /// <param name="bytes">Byte array to decode</param>
        /// <returns>Decoded string</returns>
        public static string Decode(byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
