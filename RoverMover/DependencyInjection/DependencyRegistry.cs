using RoverMover.Interfaces;
using StructureMap;

namespace RoverMover.DependencyInjection
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IRoverTurn>()
                .Singleton()
                .Use<RoverTurn>();
        }
    }
}
