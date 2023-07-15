namespace MyNUnitTests;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

//[TestFixture]
[TestFixture]
//[TestFixture(Platform.iOS)]
public class UnitTest1
{
    IApp app;
    Platform platform;

    public UnitTest1()
    {
        //this.platform = Platform.Android;
        this.platform = Platform.iOS;
    }

    [SetUp]
    public void Setup()
    {
        app = AppInitializer.StartApp(platform);
    }

    [Test]
    public void Test1()
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void AppTest1()
    {
        //Welcome to .NET Multi-platform App UI
        AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to .NET Multi-platform App UI"));
        app.Screenshot("Welcome screen.");

        Assert.IsTrue(results.Any());
        app.Tap(c => c.Marked("Click me"));
        app.Tap(c => c.Marked("Clicked 1 time"));
        app.Tap(c => c.Marked("Clicked 2 times"));

        Assert.IsTrue(results.Any());
    }
}

