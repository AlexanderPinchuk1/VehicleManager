using System.Reflection;
using VehicleManager.Foundation.Interfaces;

namespace VehicleManager.Foundation
{
    public class TypeService : ITypeService
    {
        public IEnumerable<string> GetTypeNamesOfSubclassesBySpecifyingPartOfName(Type parentType, string partOfTypeName)
        {
            return GetTypeNamesOfSubclassesOrderedByName(parentType)
              .Where(typeName => typeName.Contains(partOfTypeName))
              .ToList() ?? [];
        }

        public IEnumerable<string> GetTypeNamesOfSubclassesOrderedByName(Type parentType)
        {
            return Assembly.GetAssembly(parentType)?.GetTypes()
                .Where(type => type.IsSubclassOf(parentType))
                .Select(type => type.Name)
                .OrderBy(typeName => typeName)
                .ToList() ?? [];
        }
    }
}
