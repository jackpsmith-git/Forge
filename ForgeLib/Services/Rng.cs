using System.Security.Cryptography;
using System.Text;

namespace ForgeLib.Services
{
    public static class Rng
    {
        private static System.Security.Cryptography.RandomNumberGenerator rng = System.Security.Cryptography.RandomNumberGenerator.Create();

        internal static string GenerateRandomString(int intStringLength)
        {
            string strCapitalLetters = "QWERTYUIPASDFGHJKLZXCVBNM";
            string strSmallLetters = "qwertyupasdfghjkzxcvbnm";
            string strDigits = "123456789";
            string strSpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string strAllChar = strCapitalLetters + strSmallLetters + strDigits + strSpecialCharacters;

            StringBuilder sbStringBuilder = new StringBuilder();
            for (int i = 0; i < intStringLength; i++)
            {
                sbStringBuilder = sbStringBuilder.Append(GenerateChar(strAllChar));
            }

            return sbStringBuilder.ToString();
        }

        public static string GenerateRandomSafeString(int intStringLength)
        {
            string strCapitalLetters = "QWERTYUIPASDFGHJKLZXCVBNM";
            string strSmallLetters = "qwertyupasdfghjkzxcvbnm";
            string strDigits = "123456789";
            string strSpecialCharacters = "-_";
            string strAllChar = strCapitalLetters + strSmallLetters + strDigits + strSpecialCharacters;

            StringBuilder sbStringBuilder = new StringBuilder();
            for (int i = 0; i < intStringLength; i++)
            {
                sbStringBuilder = sbStringBuilder.Append(GenerateChar(strAllChar));
            }

            return sbStringBuilder.ToString();
        }

        private static char GenerateChar(string strAvailableChars)
        {
            var varByteArray = new byte[1];
            char chrCharacter;
            do
            {
                rng.GetBytes(varByteArray);
                chrCharacter = (char)varByteArray[0];

            } while (!strAvailableChars.Any(x => x == chrCharacter));

            return chrCharacter;
        }

    }
}
