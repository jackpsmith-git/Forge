namespace ForgeLib.Objects
{
    public class Vault
    {
        public Vault() { }

        public List<Key> keys = new();
        public string id = string.Empty;
        public string hash = string.Empty;

        /// <summary>
        /// Adds a key to the vault.
        /// </summary>
        /// <param name="key">The key to be added to the vault.</param>
        /// <returns>void</returns>
        public void AddKey(Key key)
        {
            keys.Add(key);
        }

        /// <summary>
        /// Deletes a key from the vault.
        /// </summary>
        /// <param name="key">The key to be deleted from the vault.</param>
        /// <returns>void</returns>
        public void DeleteKey(Key key)
        {
            keys.Remove(key);
        }
    }
}
