﻿
using System.IO;
using System.Text;

namespace Nhl.Api.Tests;

[TestClass]
public class ProjectStructureTests
{

    #region constants
    private const string Nhl = "Nhl";
    #endregion

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

            if(sourceCode.Contains("namespace Nhl.Api.Domain")) 
            {
                errors.Append("Domain namespace found in file: " + sourceCSharpFile.FullName + "\n");
            }
        }

        Assert.IsTrue(errors.Length == 0, errors.ToString());
    }

    #region Private Methods
    private DirectoryInfo RootDirectoryFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent;

    #endregion
}
