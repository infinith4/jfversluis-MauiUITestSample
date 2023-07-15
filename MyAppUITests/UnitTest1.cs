namespace MyAppUITests;

using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

[TestFixture(Platform.Android)]
[TestFixture(Platform.iOS)]
public class Tests
{
    IApp app;
    Platform platform;

    public Tests(Platform platform)
    {
        this.platform = platform;
    }

    [SetUp]
    public void BeforeEachTest()
    {
        app = AppInitializer.StartApp(platform);
    }

    //[Test]
    //public void AppLaunches()
    //{
    //    //Welcome to .NET Multi-platform App UI
    //    AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
    //    app.Screenshot("Welcome screen.");

    //    Assert.IsTrue(results.Any());
    //}
}
