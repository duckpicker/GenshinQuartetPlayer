using QuartetPlayer.Online;

namespace QuartetPlayer
{
    internal static class Program
    {
        public static int Port = 8080;
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }
    }
}