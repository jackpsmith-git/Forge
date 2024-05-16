namespace ForgeLib.Messages
{
    public static class Error
    {
        public const string ERROR = "Error!";

        public const string INVALID_NEW_ID = "Failed to create vault. Vault ID cannot contain spaces or special characters.";

        public const string EMPTY_DIR = "Failed to create vault. Directory cannot be empty.";

        public const string ID_EXISTS_1 = "Failed to create vault. Vault with ID \"";

        public const string ID_EXISTS_2 = "\" already exists.";

        public const string EMPTY_ID = "Failed to unlock vault. Vault ID cannot be empty.";

        public const string INVALID_VAULT_KEY = "Failed to unlock vault. Invalid key.";

        public const string EMPTY_KEY_PATH = "Failed to unlock vault. Key path cannot be empty.";

        public const string VERIFY_FAILED = "Failed to unlock vault. Invalid Vault ID or key.";

        public const string NO_VAULT = "No vault detected. Save failed.";

        public const string EXPORT_FAILED = "Failed to export vault. An unexpected error occurred.";

        public const string INVALID_REFRESH = "Invalid operation. Failed to refresh key list.";

        public const string INVALID_CLEAR = "Invalid operation. Failed to clear key list.";

        public const string MUTEX_DETECTED = "Failed to open Forge. Instance already running. Close all other instances of Forge before launching.";

        public const string REPORT_BUG = "Failed to report bug. An unexpected error occurred.";

        public const string DELETE_KEY = "Failed to delete key.";
    }
}
