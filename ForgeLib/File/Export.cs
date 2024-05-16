using ForgeLib.Objects;

namespace ForgeLib.File
{
    public static class Export
    {

        public enum ExportFormat
        {
            txt,
            json,
            csv,
            xml,
        }

        /// <summary>
        /// Exports vault data to the given format.
        /// </summary>
        /// <param name="vault">The vault to be exported.</param>
        /// <param name="format">The file format to export the vault data.</param>
        /// <param name="startupPath">The startup path of the application.</param>
        /// <returns>void</returns>
        public static void ExportVault(Vault vault, ExportFormat format)
        {
            switch (format)
            {
                case ExportFormat.txt:
                    TXT(vault);
                    return;
                case ExportFormat.csv:
                    CSV(vault);
                    return;
                case ExportFormat.json:
                    JSON(vault);
                    return;
                case ExportFormat.xml:
                    XML(vault);
                    return;
            }
        }

        private static void TXT(Vault vault)
        {
            string path = Directory.FormPath(Directory.EXPORTS, vault.id, ".txt");

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (Key key in App.activeVault.keys)
                {
                    tw.WriteLine(key.service);
                    tw.WriteLine(key.username);
                    tw.WriteLine(key.password);
                    tw.WriteLine(key.notes);
                    tw.WriteLine();
                }
            }
        }

        private static void CSV(Vault vault)
        {
            string path = Directory.FormPath(Directory.EXPORTS, vault.id, ".csv");
            string csvData = string.Empty;

            foreach (Key key in App.activeVault.keys)
            {
                csvData += key.service + ',';
                csvData += key.username + ",";
                csvData += key.password + ",";
                csvData += key.notes;
                csvData += "\r\n";
                csvData += "\r\n";
            }

            System.IO.File.WriteAllText(path, csvData);
        }

        private static void JSON(Vault vault)
        {
            string path = Directory.FormPath(Directory.EXPORTS, vault.id, ".json");
            string jsonData = string.Empty;

            foreach (Key key in App.activeVault.keys)
            {
                jsonData += Newtonsoft.Json.JsonConvert.SerializeObject(key) + "\r\n";
            }

            System.IO.File.WriteAllText(path, jsonData);
        }

        private static void XML(Vault vault)
        {
            string path = Directory.FormPath(Directory.EXPORTS, vault.id, ".xml");
            TextWriter writer = null;

            foreach (Key key in App.activeVault.keys)
            {
                try
                {
                    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Key));
                    writer = new StreamWriter(path, true);
                    serializer.Serialize(writer, key);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }

            }
        }

    }
}
