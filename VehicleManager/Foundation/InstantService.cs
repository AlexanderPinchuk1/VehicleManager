using System.Reflection;
using VehicleManager.Foundation.Interfaces;

namespace VehicleManager.Foundation
{
    public class InstantService<T> : IInstantService<T>
    {
        public IEnumerable<T> GetInstances()
        {
            var parentType = typeof(T);
            var types = Assembly.GetAssembly(parentType)?.GetTypes()
                .Where(type => type.IsSubclassOf(parentType)).ToList();

            types?.Add(parentType);

            var result = new List<T>();
            foreach (var type in types ?? Enumerable.Empty<Type>())
            {
                var constructor = type.GetConstructor([]);
                if (constructor != null)
                {
                    result.Add((T)constructor.Invoke([]));
                }
            }

            return result;
        }
    }
}
