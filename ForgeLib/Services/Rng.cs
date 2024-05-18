using System.Security.Cryptography;
using System.Text;

namespace ForgeLib.Services
{
    /// <summary>
    /// Static class containing Forge methods for generating random data.
    /// </summary>
    public static class Rng
    {
        /// <summary>
        /// Random Number Generator
        /// </summary>
        private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

        private const string CAPITAL_LETTERS = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string LOWERCASE_LETTERS = "qwertyuiopasdfghljkzxcvbnm";
        private const string DIGITS = "0123456789";

        /// <summary>
        /// Generates a random string containing all capital and lowercase letters, as well as several special characters.
        /// </summary>
        /// <param name="length">Length of the string to generate</param>
        /// <returns>Random string</returns>
        internal static string GenerateRandomString(int length)
        {
            string specialChars = "!@#$%^&*()-_=+<,>.";
            string chars = CAPITAL_LETTERS + LOWERCASE_LETTERS + DIGITS + specialChars;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb = sb.Append(GenerateChar(chars));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Generates a random string containing all capital and lowercase letters, as well as the hyphen and underscore characters.
        /// </summary>
        /// <param name="length">Length of the string to generate</param>
        /// <returns>Random string</returns>
        public static string GenerateRandomSafeString(int length)
        {
            string specialChars = "-_";
            string chars = CAPITAL_LETTERS + LOWERCASE_LETTERS + DIGITS + specialChars;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb = sb.Append(GenerateChar(chars));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Generates a random character.
        /// </summary>
        /// <param name="availableChars">Available characters to generate.</param>
        /// <returns>Generated character</returns>
        private static char GenerateChar(string availableChars)
        {
            var chars = new byte[1];
            char character;
            do
            {
                rng.GetBytes(chars);
                character = (char)chars[0];

            } while (!availableChars.Any(x => x == character));

            return character;
        }

    }
}
