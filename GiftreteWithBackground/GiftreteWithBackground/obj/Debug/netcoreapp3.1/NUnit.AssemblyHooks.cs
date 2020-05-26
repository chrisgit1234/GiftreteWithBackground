using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.97")]
[SetUpFixture]
public class GiftreteWithBackground_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(GiftreteWithBackground_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(GiftreteWithBackground_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
