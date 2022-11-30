using System.Windows.Forms;

namespace Ex05
{
    class PlayGame
    {
        public static void Play()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SettingsForm settingsForm = new SettingsForm();
            Application.Run(settingsForm);
            MemoryGameBoard gameForm = new MemoryGameBoard(settingsForm.MemoryGame);
            Application.Run(gameForm);
        }
    }
}