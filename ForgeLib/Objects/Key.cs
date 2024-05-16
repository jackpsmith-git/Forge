namespace ForgeLib.Objects
{
    public class Key
    {
        public Key() { }

        public string service = string.Empty;
        public string username = string.Empty;
        public string password = string.Empty;
        public string notes = string.Empty;

        /// <summary>
        /// Converts the key to an object array.
        /// </summary>
        /// <returns>The created object array.</returns>
        public object[] ConvertToObject()
        {
            return
            [
                service,
                username,
                password,
                notes
            ];
        }
    }
}
