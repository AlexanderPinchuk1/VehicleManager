namespace VehicleManager.Foundation.Interfaces
{
    public interface IInstantSaverService<T>
    {
        public void WriteToJsonFile(string filePath, IEnumerable<T> objectsToWrite);
    }
}
