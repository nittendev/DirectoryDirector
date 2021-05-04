using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryDirector
{
    internal class Program
    {
        private const string AppSettingsFile = "AppSettings.json";

        private static async Task Main(string[] args)
        {
            var reader = new FileReader();
            var settings = await reader.ReadSettings(AppSettingsFile);

            var source = SourceParser.GetSource(args);
            var sourceFolderName = SourceParser.GetSourceFolderName(source);

            var suffix = sourceFolderName.Split("-").Last();
            switch (suffix)
            {
                case "MOVIE":
                    Directory.Move(source, settings.TargetMovieFolder + sourceFolderName);
                    break;
                case "SERIES":
                    Directory.Move(source, settings.TargetSeriesFolder + sourceFolderName);
                    break;
            }
        }
    }
}