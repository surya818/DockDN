using Microsoft.VisualStudio.TestTools.UnitTesting;
using uitest.browser;

namespace DockerChrome
{
    [TestClass]
    public class UITest
    {
        [TestMethod]
        public void GoogTest()
        {
            var driver = UiSetup.InitDriverAndOpenWebPage("chrome", "https://google.com");
            var title = driver.Title;
            Assert.IsNotNull(driver.Title);
            Assert.IsTrue(driver.Title.Equals("Google"));
            driver.Close();
        }
    }
}
