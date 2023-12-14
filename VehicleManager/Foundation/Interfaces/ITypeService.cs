namespace VehicleManager.Foundation.Interfaces
{
    public interface ITypeService
    {
        public IEnumerable<string> GetTypeNamesOfSubclassesBySpecifyingPartOfName(Type parentType, string partOfTypeName);

        public IEnumerable<string> GetTypeNamesOfSubclassesOrderedByName(Type parentType);
    }
}
