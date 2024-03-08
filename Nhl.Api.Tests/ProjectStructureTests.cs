using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using System.Linq;

namespace Nhl.Api.Tests;

[TestClass]
public class ProjectStructureTests
{

    #region constants
    private const string Nhl = "Nhl";
    private string[] _whiteListedFiles = ["AssemblyInfo.cs", "Program.cs", "Startup.cs", "GlobalUsings.cs", "InternalPlayerEnum.cs", "Microsoft.NET.Test.Sdk.Program.cs"];

    #endregion

    [TestInitialize]
    public void TestInitialize()
    {
        if (!MSBuildLocator.IsRegistered) 
        {
            MSBuildLocator.RegisterDefaults();
        }

        RootDirectoryFolder.Refresh();
    }

    [TestMethod]
    public void ValidateProjectStructure_Should_Be_Always_Contain_Nhl()
    {

        var getSolutionFile = RootDirectoryFolder.GetFiles("*.sln", SearchOption.AllDirectories);
        Assert.IsTrue(getSolutionFile.Length > 0);

        var projectFiles = RootDirectoryFolder.GetFiles("*.csproj", SearchOption.AllDirectories);

        CollectionAssert.AllItemsAreNotNull(projectFiles);

        foreach (var projectFile in projectFiles)
        {
            Assert.IsTrue(projectFile.Name.Contains(Nhl));
            Assert.IsTrue(projectFile.Length > 0);
        }
    }

    [TestMethod]
    public void ValidateProjectStructure_Should_Never_Have_Domain_In_Namespace()
    {
        var errors = new StringBuilder();

        var getSourceCSharpFiles = RootDirectoryFolder.GetFiles("*.cs", SearchOption.AllDirectories);
        foreach (var sourceCSharpFile in getSourceCSharpFiles)
        {
            if (sourceCSharpFile.FullName.Contains("Tests"))
            {
                continue;
            }

            var sourceCode = File.ReadAllText(sourceCSharpFile.FullName);

            if (sourceCode.Contains("namespace Nhl.Api.Domain"))
            {
                errors.Append("Domain namespace found in file: " + sourceCSharpFile.FullName + "\n");
            }
        }

        Assert.IsTrue(errors.Length == 0, errors.ToString());
    }

    [TestMethod]
    public async Task ValidateProjectStructure_Should_Never_Have_Non_File_Scoped_Namespace()
    {
        using var workspace = MSBuildWorkspace.Create();
        var errors = new StringBuilder();

        var solutionFiles = RootDirectoryFolder.GetFiles("*.sln", SearchOption.AllDirectories);
        var solution = await workspace.OpenSolutionAsync($"{solutionFiles.First().FullName}");

        foreach (var project in solution.Projects)
        {
            var files = project.Documents;

            foreach (var file in files.Where(f => !_whiteListedFiles.Contains(f.Name)))
            {
                var syntaxTree = await file.GetSyntaxTreeAsync();
                var namespaceDeclaration = syntaxTree.GetRoot().DescendantNodes().FirstOrDefault(n => n.IsKind(SyntaxKind.FileScopedNamespaceDeclaration));

                if (namespaceDeclaration is null)
                {
                    errors.AppendLine($"{file.Name} has non-file scoped namespace\n");
                }
            }
        }

        var allErrors = errors.ToString();
        Assert.IsTrue(errors.Length == 0, errors.ToString());
    }

    #region Private Methods
    private DirectoryInfo RootDirectoryFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent;

    #endregion
}
