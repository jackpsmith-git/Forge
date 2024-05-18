using System.Xml.Serialization;
using ForgeLib.Objects;

namespace ForgeLib.Services
{
    /// <summary>
    /// Static class containing Forge methods for serilizing and deserializing data
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// Serializes a vault to XML.
        /// </summary>
        /// <param name="vault"></param>
        /// <returns>XML string containing vault data.</returns>
        public static string SerializeVault(Vault vault)
        {
            try
            {
                StringWriter sw = new();
                XmlSerializer serializer = new(vault.GetType());
                serializer.Serialize(sw, vault);
                return sw.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Deserializes XML data into a vault object.
        /// </summary>
        /// <param name="xmlData">XML vault data.</param>
        /// <returns>Vault object containing deserialized data.</returns>
        public static Vault? DeserializeVault(string xmlData)
        {
            try
            {
                StringReader sr = new(xmlData);
                XmlSerializer serializer = new(typeof(Vault));
                return (Vault)serializer.Deserialize(sr);
            }
            catch
            {
                return null;
            }
        }
    }
}
