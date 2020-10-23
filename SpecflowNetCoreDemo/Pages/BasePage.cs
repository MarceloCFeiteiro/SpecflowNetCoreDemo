using SpecflowNetCoreDemo.Drivers;
using SpecflowNetCoreDemo.Utils;
using System;

namespace SpecflowNetCoreDemo.Pages
{
    public class BasePage
    {
        public readonly WebDriverBuilder _webDriverBuilder;
        public SeleniumActions _seleniumActions;

        public BasePage(WebDriverBuilder webDriverBuilder, SeleniumActions seleniumActions)
        {
            _webDriverBuilder = webDriverBuilder;
            _seleniumActions = seleniumActions;
        }

        public void NavegarPara(string url)
        {
            _webDriverBuilder.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _webDriverBuilder.WebDriver.Navigate().GoToUrl(url);
        }
    }
}