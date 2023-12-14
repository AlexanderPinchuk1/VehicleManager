using VehicleManager.Foundation.Interfaces;

namespace VehicleManager.Foundation
{
    public class IntArrayService : IIntArrayService
    {
        public IEnumerable<int> MissingElements(int[] arr)
        {
            return Enumerable.Range(arr[0], arr[^1] - arr[0]).Except(arr);
        }
    }
}
