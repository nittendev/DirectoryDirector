using System.Linq;

namespace DirectoryDirector
{
    public static class SourceParser
    {
        public static string GetSource(string[] args)
        {
            return args.FirstOrDefault();
        }

        public static string GetSourceFolderName(string sourceDirectory)
        {
            var targetFolder = sourceDirectory.Split("\\");
            return targetFolder.Last();
        }
    }
}