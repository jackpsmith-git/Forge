![ForgeLogo](https://i0.wp.com/jackpsmith.com/wp-content/uploads/2024/05/ForgeLogo-2.png?w=1625&ssl=1)

# Forge Password Management Utility

Forge is a free and open source (FOSS) portable password management utility for Windows 10/11.

The current version of Forge is v.1.0.1 released on May 17, 2024.
<p>&nbsp;</p>

## Description

Forge works by storing your data in encrypted files called vaults. Vaults live in a subdirectory alongside the executable so that you always have control over your own data. Forge collects no user data.

When you give Forge your sensitive data, it is never written to disk in an unencrypted state. Forge serializes and encrypts the vault data in memory before writing to disk, and can only decrypt the data if the correct AES key is provided.
<p>&nbsp;</p>

### Features
* AES key encryption
* SHA512 vault key hashing
* Full portability
* Winforms GUI
* Export to
   * .txt
   * .csv
   * .json
   * .xml
<p>&nbsp;</p>

### Disclaimer

Forge is not responsible for any lost or exposed data. It is the end user's responsibility to backup and store their own data. 
<p>&nbsp;</p>

## Getting Started

You can find the latest build of Forge (v.1.0.1) in the Forge_x64 directory in the repository. Additionally, you have the option to compile from source with Visual Studio 2022.
<p>&nbsp;</p>

### Dependencies

* Windows 10/11 - Forge only works on Windows 10/11 operating systems as it relies on the Win32 API.
* .NET 8.0 - Forge is dependent on the .NET 8.0 runtime which is the current LTS from Microsoft. You can download .NET 8.0 [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
<p>&nbsp;</p>

### Creating a Vault

To create a vault, launch ForgeGUI.exe and click on "New Vault." Choose a Vault ID that will serve as a username and a folder where your secure vault key will be generated. This key will be an encoded file that will be required to unlock your vault. Do not share this key. Keep it in a secure location on your computer or on an external drive. While all personal data is encrypted, anyone with your vault key and access to your user account on your PC will be able to access your sensitive info. If you lose this key, you will lose access to all stored data. Click "Create Vault" to confirm creation of your new vault. 
<p>&nbsp;</p>

### Opening a vault

To unlock a vault, enter the ID that you chose when creating your vault. Open the file dialogue and select the file containing your vault key. Click "Unlock Vault" to open your vault. This may take a few seconds. BCrypt's enhanced hashing algorithm increases the work factor of the hashing function which slows down the process intentionally in order to defend against brute force attacks.

Inside your vault, you can navigate the GUI to add, edit, and delete data that you would like to store. Each entry is stored in an object called a Key. Each key contains a service, username, password, and notes.
<p>&nbsp;</p>

## Help

For questions, bug reports, feature suggestions, or general help, contact me at jackpsmith@jackpsmith.com . 
<p>&nbsp;</p>

## Authors

[Jack P Smith](https://www.jackpsmith.com) - jackpsmith@jackpsmith.com
<p>&nbsp;</p>

## Version History

* 2.0.0 (COMING SOON) 
    * Command line interface
    * Additional export formats
    * Resizable GUI
    * Dark mode
    * Accessibility updates
    * Copy to clipboard
    * Dropdown for common services
    * Export to
        * .xlsx
        * .docx
        * .ods
        * .tsv
        * .md
        * .rtf
        * .pdf
    * Right click menu
    * Ability to manually edit key list without additional menu
    * ForgeLib general improvements
* 1.0.1 - May 2024
    * Fixed bug where Forge could not write decryption key and initialization vector to readonly files
    * Improved documentation
* 1.0.0 - May 2024
    * Initial Release
<p>&nbsp;</p>

## License

Forge is licensed under the MIT License - see the LICENSE.txt file for details