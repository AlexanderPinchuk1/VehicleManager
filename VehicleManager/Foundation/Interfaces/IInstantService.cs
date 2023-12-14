namespace VehicleManager.Foundation.Interfaces
{
    public interface IInstantService<T>
    {
        public IEnumerable<T> GetInstances();
    }
}
