using ForgeLib;
using ForgeLib.Messages;

namespace ForgeGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new(false, App.GUID))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show(Error.MUTEX_DETECTED, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new GUI());

                }
            }
        }
    }
}