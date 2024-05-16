namespace ForgeLib.Messages
{
    public static class Warning
    {
        public const string WARNING = "Warning!";

        public const string UNLOCKED_VAULT = "A vault has been left unlocked! Lock your vault before leaving your device unattended.";

        public const string CONFIRM_DELETE = "Are you sure you would like to delete this key? Deleted data will not be recoverable.";

        public const string EXPORT = "Vault exported successfully. " +
            "Exported file can be found in the \"exports\" folder in the same directory as Forge. \n \n" +
            "DO NOT LEAVE YOUR EXPORTS IN THE FORGE DIRECTORY. " +
            "EXPORTS ARE NOT ENCRYPTED AND ARE NOT SECURE. \n \n" +
            "Exports exist primarily so you can easily transfer your data to a third party application. It is best to delete your exports as soon as you are finished using them. \n \n" +
            "FORGE WILL AUTOMATICALLY DELETE ALL FILES IN THE EXPORTS FOLDER THE NEXT TIME FORGE IS LAUNCHED.";

    }
}
