using Newtonsoft.Json;
using VehicleManager.Foundation.Interfaces;

namespace VehicleManager.Foundation
{
    public class InstantSaverService<T> : IInstantSaverService<T>
    {
        public void WriteToJsonFile(string filePath, IEnumerable<T> objectsToWrite)
        {
            using var fileStream = new StreamWriter(filePath, false);

            string jsonTransport = JsonConvert.SerializeObject(objectsToWrite, Formatting.Indented, new JsonSerializerSettings
            { 
                TypeNameHandling = TypeNameHandling.All, 
                PreserveReferencesHandling = PreserveReferencesHandling.Objects 
            });
            
            fileStream.Write(jsonTransport);
        }
    }
}
