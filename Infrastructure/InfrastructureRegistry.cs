using Domain;
using StructureMap;

namespace Infrastructure
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            Scan(_ =>
            {
                _.TheCallingAssembly();
                _.AssemblyContainingType<IService>();
                _.AddAllTypesOf<IService>();
                _.ConnectImplementationsToTypesClosing(typeof(IRepository<>));
                _.WithDefaultConventions();
            });
        }
    }
}
