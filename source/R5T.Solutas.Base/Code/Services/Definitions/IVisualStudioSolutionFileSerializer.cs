using System;

using R5T.Cambridge.Types;
using R5T.Megara;using R5T.T0064;


namespace R5T.Solutas
{[ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileSerializer : IFileSerializer<SolutionFile>,IServiceDefinition
    {
    }
}
