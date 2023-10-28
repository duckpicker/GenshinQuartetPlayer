
namespace QuartetPlayer
{
    internal class MidiFolder
    {
        protected static string myDocuments = "";
        public static string downloadArea = "";
        protected static string pattern = "*.mid";
        public static List<string> files = new List<string>();
        public static string midiPath = "";
        public static void CheckFolder() {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GenshinQuartetPlayer"));
            myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            downloadArea = Path.Combine(myDocuments, "GenshinQuartetPlayer");
        }

        public static void GetMidiFiles() {
            files = Directory.GetFiles(downloadArea, pattern).ToList();
        }

        public static void PrintFiles() {
            CheckFolder();
            GetMidiFiles();
        }
    }
}
