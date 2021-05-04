using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DirectoryDirector
{
    public class FileReader
    {
        public async Task<AppSettings> ReadSettings(string jsonLocation)
        {
            try
            {
                await using var fsSource = new FileStream(jsonLocation, FileMode.Open, FileAccess.Read);

                var appSettings = await JsonSerializer.DeserializeAsync<AppSettings>(fsSource, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});

                return appSettings;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}