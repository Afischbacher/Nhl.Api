using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.MethodLevel)]
namespace Nhl.Api.Tests;

internal class AssemblyInfo
{
}
