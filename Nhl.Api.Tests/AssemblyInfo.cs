using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 16, Scope = ExecutionScope.MethodLevel)]
namespace Nhl.Api.Tests
{
    internal class AssemblyInfo
    {
    }
}
